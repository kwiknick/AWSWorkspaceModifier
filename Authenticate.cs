using System;
using System.Configuration;
using System.Windows.Forms;

namespace Willard.DevOps.AWS.APIWrapper
{
    public partial class Authenticate : Form
  {
    public static string awsAccessKey;
    public static string awsSecretKey;
    public static Amazon.Runtime.BasicAWSCredentials awsCredentials;

    public Authenticate()
    {
      InitializeComponent();
    }

    private void AuthenticateButton_Click(object sender, EventArgs e)
    {
      AuthenticateWithAWS();
    }

    public void AuthenticateWithAWS()
    {
      awsAccessKey = ConfigurationManager.AppSettings["AWSAccessKey"];
      awsSecretKey = ConfigurationManager.AppSettings["AWSSecretKey"];

      if (string.IsNullOrEmpty(awsAccessKey) || string.IsNullOrEmpty(awsSecretKey))
      {
        awsAccessKey = awsAccessKeyTextBox.Text;
        awsSecretKey = awsSecretKeyTextBox.Text;
      }      

      awsCredentials = new Amazon.Runtime.BasicAWSCredentials(awsAccessKey, awsSecretKey);
      WorkspaceCreator.awsClient = new Amazon.WorkSpaces.AmazonWorkSpacesClient(awsCredentials, Amazon.RegionEndpoint.USEast1);
      WorkspaceCreator.awsDirectoryClient = new Amazon.DirectoryService.AmazonDirectoryServiceClient(awsCredentials, Amazon.RegionEndpoint.USEast1);
    }

    public void AuthenticateWithAWS(Amazon.RegionEndpoint awsRegion)
    {
      awsAccessKey = ConfigurationManager.AppSettings["AWSAccessKey"];
      awsSecretKey = ConfigurationManager.AppSettings["AWSSecretKey"];

      if (string.IsNullOrEmpty(awsAccessKey) || string.IsNullOrEmpty(awsSecretKey))
      {
        awsAccessKey = awsAccessKeyTextBox.Text;
        awsSecretKey = awsSecretKeyTextBox.Text;
      }

      awsCredentials = new Amazon.Runtime.BasicAWSCredentials(awsAccessKey, awsSecretKey);
      WorkspaceCreator.awsClient = new Amazon.WorkSpaces.AmazonWorkSpacesClient(awsCredentials, awsRegion);
      WorkspaceCreator.awsDirectoryClient = new Amazon.DirectoryService.AmazonDirectoryServiceClient(awsCredentials, awsRegion);
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
      ResetAuthenticateForm();
    }

    private void ResetAuthenticateForm()
    {
      awsAccessKeyTextBox.Text = string.Empty;
      awsSecretKeyTextBox.Text = string.Empty;
    }

    private void AwsSecretKeyTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        AuthenticateWithAWS();
      }
      if (e.KeyChar == (char)Keys.Escape)
      {
        ResetAuthenticateForm();
      }
    }
  }
}
