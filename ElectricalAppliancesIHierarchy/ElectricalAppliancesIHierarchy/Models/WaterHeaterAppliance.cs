namespace ElectricalAppliancesIHierarchy.Models
{
    public abstract class WaterHeaterAppliance : ElectricalAppliance
    {
        public double WaterCapacity { get; set; }
        public bool WithFullnessIndicators { get; set; }
    }
}
