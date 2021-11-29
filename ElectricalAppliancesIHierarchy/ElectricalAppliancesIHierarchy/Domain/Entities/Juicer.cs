using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalAppliancesIHierarchy.Domain.Entities
{
    public class Juicer
    {
        public int Id { get; set; }
        public string FoodForCooking { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufactorer { get; set; }
        public double Power { get; set; }
        public double PossibleJuiceFromProductPercent { get; set; }
    }
}
