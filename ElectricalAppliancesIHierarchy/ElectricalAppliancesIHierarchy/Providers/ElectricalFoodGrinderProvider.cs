using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricalAppliancesIHierarchy.Domain.Entities;
using ElectricalAppliancesIHierarchy.Models.FoodRelatedAppliances;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Providers
{
    public class ElectricalFoodGrinderProvider : IElectricalFoodGrinderProvider
    {
        public ElecticalFoodGrinder[] GetElecticalFoodGrinders()
        {
            return new ElecticalFoodGrinder[]
            {
                new ElecticalFoodGrinder
                {
                    Id = 1,
                    FoodForCooking = "Green",
                    Manufactorer = "Electical Food Grinder manufacturer 1",
                    Name = "Electical Food Grinder 1",
                    PossibleAttachmentType = AttachmentType.Knives,
                    Power = 100,
                    Price = 23.1
                },
                new ElecticalFoodGrinder
                {
                    Id = 2,
                    FoodForCooking = "Cucumber",
                    Manufactorer = "Electical Food Grinder manufacturer 2",
                    Name = "Electical Food Grinder 2",
                    PossibleAttachmentType = AttachmentType.Cutting,
                    Power = 200,
                    Price = 8.2
                }
            };
        }
    }
}
