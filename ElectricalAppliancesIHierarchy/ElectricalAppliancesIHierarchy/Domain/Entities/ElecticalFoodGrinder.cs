using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricalAppliancesIHierarchy.Models.FoodRelatedAppliances;

namespace ElectricalAppliancesIHierarchy.Domain.Entities
{
    public class ElecticalFoodGrinder
    {
        public int Id { get; set; }
        public string FoodForCooking { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufactorer { get; set; }
        public double Power { get; set; }
        public AttachmentType PossibleAttachmentType { get; set; }
    }
}
