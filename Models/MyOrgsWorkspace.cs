using Amazon.WorkSpaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Willard.DevOps.AWS.APIWrapper.Models
{
  public class MyOrgsWorkspace //: Workspace
  {
    public string BundleId { get; set; }
    public string UserName { get; set; }
    public string WorkspaceId { get; set; }
    public string RegistrationId { get; set; }
    public DateTime LastKnownUserConnectionTimestamp { get; set; }
  }
}
