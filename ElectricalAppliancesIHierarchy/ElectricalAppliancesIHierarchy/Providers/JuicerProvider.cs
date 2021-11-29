using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricalAppliancesIHierarchy.Domain.Entities;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Providers
{
    public class JuicerProvider : IJuicerProvider
    {
        public Juicer[] GetJuicers()
        {
            return new Juicer[]
            {
                new Juicer
                {
                    Id = 1,
                    FoodForCooking = "Orange",
                    Manufactorer = "Juicer Manufacturer 1",
                    Name = "Juicer 1",
                    PossibleJuiceFromProductPercent = 0.8,
                    Power = 220,
                    Price = 80.1
                },
                new Juicer
                {
                    Id = 2,
                    FoodForCooking = "Apple",
                    Manufactorer = "Juicer Manufacturer 2",
                    Name = "Juicer 2",
                    PossibleJuiceFromProductPercent = 0.6,
                    Power = 210,
                    Price = 87.1
                }
            };
        }
    }
}
