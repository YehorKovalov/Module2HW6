using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalAppliancesIHierarchy.Models.WaterHeaterAppliances
{
    public class BoilerDTO : WaterHeaterAppliance, IPlugableIn
    {
        public BoilerType Type { get; set; }
        public bool PluggedIn { get; set; }
    }
}
