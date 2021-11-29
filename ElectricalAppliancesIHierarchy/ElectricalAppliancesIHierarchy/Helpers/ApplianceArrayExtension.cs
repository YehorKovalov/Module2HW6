using System;
using System.Collections.Generic;
using ElectricalAppliancesIHierarchy.Models;

namespace ElectricalAppliancesIHierarchy.Helpers
{
    public static class ApplianceArrayExtension
    {
        public static ElectricalAppliance FindFirstInRangeOrNull(
            this ElectricalAppliance[] appliances, int min, int max)
        {
            if (min < 0 || max < min || appliances == null)
            {
                throw new ArgumentException();
            }

            foreach (var appliance in appliances)
            {
                if (appliance.Power.IsInRange(min, max))
                {
                    return appliance;
                }
            }

            return null;
        }

        public static ElectricalAppliance[] SortAppliances(
            this ElectricalAppliance[] appliances,
            IComparer<ElectricalAppliance> comparer)
        {
            if (appliances == null)
            {
                throw new ArgumentNullException();
            }

            Array.Sort(appliances, comparer);
            return appliances;
        }

        public static ElectricalAppliance[] AppendRange(
            this ElectricalAppliance[] electricalAppliances,
            ElectricalAppliance[] range)
        {
            if (range == null)
            {
                throw new ArgumentNullException();
            }

            if (electricalAppliances == null)
            {
                electricalAppliances = Array.Empty<ElectricalAppliance>();
            }

            var appiancesLength = electricalAppliances.Length;
            var result = new ElectricalAppliance[appiancesLength + range.Length];

            electricalAppliances.CopyTo(result, 0);
            range.CopyTo(result, appiancesLength);
            return result;
        }

        private static bool IsInRange(this double parameter, int min, int max)
        {
            return parameter >= min && parameter <= max;
        }
    }
}
