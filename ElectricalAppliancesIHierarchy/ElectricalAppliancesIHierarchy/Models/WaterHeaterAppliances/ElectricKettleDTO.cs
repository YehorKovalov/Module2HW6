using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalAppliancesIHierarchy.Models.WaterHeaterAppliances
{
    public class ElectricKettleDTO : WaterHeaterAppliance, IPlugableIn
    {
        public OpeningLidPrinciple OpeningLidPrinciple { get; set; }
        public bool PluggedIn { get; set; }
    }
}
