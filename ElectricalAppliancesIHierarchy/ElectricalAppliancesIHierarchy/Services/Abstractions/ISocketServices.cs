using ElectricalAppliancesIHierarchy.Models;

namespace ElectricalAppliancesIHierarchy.Services.Abstractions
{
    public interface ISocketServices
    {
        bool PlugInElectricalAppliance(IPlugableIn plugableIn);
    }
}