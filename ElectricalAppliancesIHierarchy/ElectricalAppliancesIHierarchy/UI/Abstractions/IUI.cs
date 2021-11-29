using ElectricalAppliancesIHierarchy.Models;

namespace ElectricalAppliancesIHierarchy.UI.Abstractions
{
    public interface IUI
    {
        void DisplayAppliance(ElectricalAppliance appliance);
        void DisplayPlagableInAppliances(ElectricalAppliance[] electricalAppliances);
        void DisplayElectricalAppliances(ElectricalAppliance[] appliances);
        void DisplayMessage(string message);
    }
}
