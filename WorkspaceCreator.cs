using Amazon.WorkSpaces.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Windows.Forms;
using Willard.DevOps.AWS.APIWrapper.Models;

namespace Willard.DevOps.AWS.APIWrapper
{
  public partial class WorkspaceCreator : Form
  {
    public static Amazon.WorkSpaces.AmazonWorkSpacesClient awsClient;
    public static Amazon.DirectoryService.AmazonDirectoryServiceClient awsDirectoryClient;
    public static string awsDirectoryUsers;
    public DescribeWorkspacesResponse currentWorkspaces;
    public List<WorkspaceDirectory> availableDirectories;

    public WorkspaceCreator()
    {
      InitializeComponent();
      Authenticate awsAuth = new Authenticate();
      awsAuth.AuthenticateWithAWS();

      // TODO: figure out how to get the popups to swap gracefully if the Auth is not working.
      //try
      //{
      //  awsClient.DescribeWorkspaceBundles();
      //}
      //catch (Exception e)
      //{
      //  // Credentials are wrong, so give an oportunity to fix them.
      //  this.Hide();
      //  awsAuth.Show();
      //}

      regionDropdown.Items.AddRange(WorkspaceAvailableRegions.GetWorkspaceAvailableRegions().ToArray());
      bundleDropdown.Enabled = false;
      createWorkspaceButton.Enabled = false;
    }

    #region Listeners
    private void WorkspaceCreator_Load(object sender, EventArgs e)
    {

    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void CreateWorkspaceButton_Click(object sender, EventArgs e)
    {
      WorkspaceDirectory directory = (WorkspaceDirectory)directoryDropdown.SelectedItem;
      WorkspaceBundle bundle = (WorkspaceBundle)bundleDropdown.SelectedItem;
      ADUser user = (ADUser)userNameDropdown.SelectedItem;

      var workspaceExists = currentWorkspaces.Workspaces.FirstOrDefault(w => w.UserName.ToLower() == user.DisplayName.ToLower().Replace(" ", "."));

      if (workspaceExists == null)
      {
        var tagsList = new List<Tag> { new Tag { Key = "Created", Value = $"{DateTime.Now.ToShortDateString()}" } };

        var workspaceRequest = new CreateWorkspacesRequest();
        workspaceRequest.Workspaces = new List<WorkspaceRequest>
      {
        new WorkspaceRequest
        {
          BundleId = bundle.BundleId,
          DirectoryId = directory.DirectoryId,
          UserName = user.DisplayName.ToLower().Replace(" ", "."),
          Tags = tagsList,
          WorkspaceProperties = new WorkspaceProperties
          {
            RunningMode = Amazon.WorkSpaces.RunningMode.AUTO_STOP,
            RunningModeAutoStopTimeoutInMinutes = 60
          }
        }
      };

        var createWorkspaceResponse = awsClient.CreateWorkspaces(workspaceRequest);
      }
      else if (workspaceExists.State != "PENDING")
      {
        DialogResult dialogResult = MessageBox.Show($"A Workspace already exists for {workspaceExists.UserName} in the selected region.  Would you like to Permanently Delete it?",
                                                    "Workspace Deletion Warning",
                                                    MessageBoxButtons.YesNoCancel,
                                                    MessageBoxIcon.Warning);
        if (dialogResult == DialogResult.Yes)
        {
          var workspaceDeleteResponse = awsClient.TerminateWorkspaces(new TerminateWorkspacesRequest
          {
            TerminateWorkspaceRequests = new List<TerminateRequest> { new TerminateRequest { WorkspaceId = workspaceExists.WorkspaceId } }
          });
        }
        //var workspaceDeleteRequest = awsClient.RebuildWorkspaces(new RebuildWorkspacesRequest { RebuildWorkspaceRequests = new List<RebuildRequest> { RebuildWorkspacesRequest} })
      }
    }

    private void RegionDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      Amazon.RegionEndpoint region = (Amazon.RegionEndpoint)regionDropdown.SelectedItem;
      Authenticate auth = new Authenticate();

      try
      {
        auth.AuthenticateWithAWS(region);

        // Check Connection with a quick AWS Call
        awsClient.DescribeWorkspaceBundles();
      }
      catch (Exception ex)
      {
        MessageBox.Show("The AWS Credentials supplied in the config file do not seem to be correct or there is " +
                        "a network error.  Please fix this and run the program again.", "AWS Connection Issue",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        Environment.Exit(1);
      }      

      createWorkspaceButton.Enabled = false;

      PopulateDirectoriesDropdown();
      PopulateWorkspaceGridView();
      PopulateBundlesDropdown();
      PopulateUserDropdown();
    }

    private void BundleDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      EnableButtonIfPreReqsMet();
    }

    private void UserNameDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      EnableButtonIfPreReqsMet();
    }

    private void DirectoryDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      EnableButtonIfPreReqsMet();
    }
    #endregion

    private void PopulateWorkspaceGridView()
    {
      currentWorkspaces = awsClient.DescribeWorkspaces();
      List<MyOrgsWorkspace> myOrgsWorkspaces = new List<MyOrgsWorkspace>();

      foreach (var workspace in currentWorkspaces.Workspaces)
      {
        var workspaceConnectionRequest = new DescribeWorkspacesConnectionStatusRequest();
        workspaceConnectionRequest.WorkspaceIds.Add(workspace.WorkspaceId);

        var workspaceConnectionResponse = awsClient.DescribeWorkspacesConnectionStatus(workspaceConnectionRequest);
        var workspaceConnectionStatus = workspaceConnectionResponse.WorkspacesConnectionStatus;

        myOrgsWorkspaces.Add(new MyOrgsWorkspace
        {
          WorkspaceId = workspace.WorkspaceId,
          RegistrationId = availableDirectories.FirstOrDefault().RegistrationCode,
          UserName = workspace.UserName,
          LastKnownUserConnectionTimestamp = workspaceConnectionStatus.Where(w => w.WorkspaceId == workspace.WorkspaceId).Select(c => c.LastKnownUserConnectionTimestamp).FirstOrDefault()
        });
      }

      var bindingList = new BindingList<MyOrgsWorkspace>(myOrgsWorkspaces);
      var source = new BindingSource(bindingList, null);
      workspaceDataGridView.DataSource = source;


    }

    public void PopulateBundlesDropdown()
    {
      var availableBundles = awsClient.DescribeWorkspaceBundles().Bundles;
      bundleDropdown.Items.Clear();
      bundleDropdown.Items.AddRange(availableBundles.ToArray());
      bundleDropdown.DisplayMember = "Name";
      bundleDropdown.ValueMember = "BundleId";
      bundleDropdown.Enabled = true;
    }

    public void PopulateDirectoriesDropdown()
    {
      availableDirectories = awsClient.DescribeWorkspaceDirectories().Directories;
      directoryDropdown.Items.Clear();
      directoryDropdown.Items.AddRange(availableDirectories.ToArray());
      directoryDropdown.DisplayMember = "Alias";
      directoryDropdown.ValueMember = "DirectoryId";
      directoryDropdown.Enabled = true;
    }

    private void PopulateUserDropdown()
    {
      var availableUsers = GetADUsers();

      if (availableUsers.Count > 0)
      {
        availableUsers = availableUsers.OrderBy(u => u.UserName).ToList();
      }

      userNameDropdown.Items.Clear();
      foreach (var user in availableUsers)
      {
        userNameDropdown.Items.Add(user);
        userNameDropdown.DisplayMember = "DisplayName";
        userNameDropdown.ValueMember = "Email";
      }

      userNameDropdown.Enabled = true;
    }

    #region HelperMethods
    private void EnableButtonIfPreReqsMet()
    {
      if (bundleDropdown.SelectedItem != null &&
          directoryDropdown.SelectedItem != null &&
          userNameDropdown.SelectedItem != null)
      {
        createWorkspaceButton.Enabled = true;
      }
    }

    private List<ADUser> GetADUsers()
    {
      try
      {
        List<ADUser> lstADUsers = new List<ADUser>();

        // create your domain context
        PrincipalContext ctx = new PrincipalContext(ContextType.Domain);

        // find the group in question (or load it from e.g. your list)
        var groupPrincipalList = new List<GroupPrincipal>();
        groupPrincipalList.Add(GroupPrincipal.FindByIdentity(ctx, "Development"));
        groupPrincipalList.Add(GroupPrincipal.FindByIdentity(ctx, "DevOps"));

        //Use the below 2 lines to see what groups a user is a member of.
        //Principal user = Principal.FindByIdentity(ctx, "nick.willard");
        //var groups = userEm.GetGroups();        

        foreach (var groupPrincipal in groupPrincipalList)
        {
          ConsolidateDevADUsers(lstADUsers, groupPrincipal);
        }

        return lstADUsers;
      }
      catch (Exception ex)
      {
        return null;
      }
    }

    private static void ConsolidateDevADUsers(List<ADUser> lstADUsers, GroupPrincipal group)
    {
      // if found....
      if (group != null)
      {
        UserPrincipal user;
        PrincipalSearchResult<Principal> lstUsers;
        lstUsers = group.GetMembers();
        // iterate over members
        foreach (object obj in lstUsers)
        {
          user = obj as UserPrincipal;
          if (user != null)
          {
            Console.WriteLine("{0}: {1}", user.StructuralObjectClass, user.DisplayName);

            ADUser objADUser = new ADUser();
            objADUser.Email = user.EmailAddress;
            objADUser.UserName = user.UserPrincipalName;
            objADUser.DisplayName = user.DisplayName;
            objADUser.IsEnabled = user.Enabled;

            if (!lstADUsers.Contains(objADUser))
            {
              lstADUsers.Add(objADUser);
            }
          }
        }
      }
    }
    #endregion

  }
}
