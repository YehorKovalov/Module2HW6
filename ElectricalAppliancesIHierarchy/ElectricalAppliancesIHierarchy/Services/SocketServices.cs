using ElectricalAppliancesIHierarchy.Models;
using ElectricalAppliancesIHierarchy.Services.Abstractions;

namespace ElectricalAppliancesIHierarchy.Services
{
    public class SocketServices : ISocketServices
    {
        public bool PlugInElectricalAppliance(IPlugableIn plugableIn)
        {
            if (plugableIn == null)
            {
                return false;
            }

            plugableIn.PluggedIn = true;
            return true;
        }
    }
}
