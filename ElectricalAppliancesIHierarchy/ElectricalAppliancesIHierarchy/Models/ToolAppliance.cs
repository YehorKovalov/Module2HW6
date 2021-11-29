using ElectricalAppliancesIHierarchy.Models.Enums;

namespace ElectricalAppliancesIHierarchy.Models
{
    public abstract class ToolAppliance : ElectricalAppliance
    {
        public SecurityClass SecurityClass { get; set; }
        public ApplicationArea ApplicationArea { get; set; }
    }
}
