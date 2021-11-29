using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricalAppliancesIHierarchy.Models;

namespace ElectricalAppliancesIHierarchy.Helpers
{
    public class AppliancesPowerComparer : IComparer<ElectricalAppliance>
    {
        public int Compare(ElectricalAppliance x, ElectricalAppliance y)
        {
            return x.Power.CompareTo(y.Power);
        }
    }
}
