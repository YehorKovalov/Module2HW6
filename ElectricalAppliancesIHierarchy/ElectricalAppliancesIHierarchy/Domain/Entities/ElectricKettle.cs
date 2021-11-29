using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricalAppliancesIHierarchy.Models.WaterHeaterAppliances;

namespace ElectricalAppliancesIHierarchy.Domain.Entities
{
    public class ElectricKettle
    {
        public int Id { get; set; }
        public OpeningLidPrinciple OpeningLidPrinciple { get; set; }
        public double WaterCapacity { get; set; }
        public bool WithFullnessIndicators { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufactorer { get; set; }
        public double Power { get; set; }
        public bool PluggedIn { get; set; }
    }
}
