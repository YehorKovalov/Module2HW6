using ElectricalAppliancesIHierarchy.Models;

namespace ElectricalAppliancesIHierarchy.Services.Abstractions
{
    public interface IElectricalApplianceServices
    {
        ElectricalAppliance FindFirstByPowerInRangeOrNull(ElectricalAppliance[] appliances, int minPower, int maxPower);
        ElectricalAppliance[] GetAppliances();
        ElectricalAppliance[] SortAppliancesByPower(ElectricalAppliance[] appliances);
        void PlugInPlugableAppliances(ElectricalAppliance[] appliances);
    }
}