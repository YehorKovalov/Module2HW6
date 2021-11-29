using ElectricalAppliancesIHierarchy.Models.WaterHeaterAppliances;

namespace ElectricalAppliancesIHierarchy.Domain.Entities
{
    public class Boiler
    {
        public int Id { get; set; }
        public BoilerType Type { get; set; }
        public double WaterCapacity { get; set; }
        public bool WithFullnessIndicators { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufactorer { get; set; }
        public double Power { get; set; }
        public bool PluggedIn { get; set; }
    }
}
