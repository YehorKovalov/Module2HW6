using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalAppliancesIHierarchy.Models.FoodRelatedAppliances
{
    public class DrinksMakerDTO : FoodRelatedAppliance, IPlugableIn
    {
        public bool RequiresControl { get; set; }
        public bool PluggedIn { get; set; }
    }
}
