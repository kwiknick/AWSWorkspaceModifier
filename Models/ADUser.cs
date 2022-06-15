using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Willard.DevOps.AWS.APIWrapper
{
  public class ADUser
  {
    public string Email { get; set; }
    public string UserName { get; set; }
    public string DisplayName { get; set; }
    public bool? IsEnabled { get; set; }
    public bool isMapped { get; set; }
  }
}
