using Amazon;
using System.Collections.Generic;

namespace Willard.DevOps.AWS.APIWrapper
{
  public static class WorkspaceAvailableRegions
  {
    public static List<RegionEndpoint> GetWorkspaceAvailableRegions()
    {
      return new List<RegionEndpoint>
      {
        RegionEndpoint.USEast1,       // N. Virginia
        RegionEndpoint.USWest2,       // Oregon
        RegionEndpoint.APNortheast2,  // Seoul
        RegionEndpoint.APSoutheast1,  // Singapore
        RegionEndpoint.APSoutheast2,  // Sydney
        RegionEndpoint.APNortheast1,  // Tokyo
        RegionEndpoint.CACentral1,    // Canada (Central)
        RegionEndpoint.EUCentral1,    // EU (Frankfurt)
        RegionEndpoint.EUWest1,       // EU (Ireland)
        RegionEndpoint.EUWest2,       // EU (London)
        RegionEndpoint.SAEast1        // South America (Sao Paulo)
      };
    }
  }
}
