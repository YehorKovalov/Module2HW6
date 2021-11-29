using ElectricalAppliancesIHierarchy.Domain.Entities;
using ElectricalAppliancesIHierarchy.Models.WaterHeaterAppliances;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Providers
{
    public class BoilerProvider : IBoilerProvider
    {
        public Boiler[] GetBoilers()
        {
            return new Boiler[]
            {
                new Boiler
                {
                    Id = 1,
                    Manufactorer = "Boiler Manufacturer 1",
                    Name = "Boiler name 1",
                    Power = 10,
                    Price = 14.2,
                    Type = BoilerType.InderectHeatingBoiler,
                    WaterCapacity = 200,
                    WithFullnessIndicators = true
                },
                new Boiler
                {
                    Id = 2,
                    Manufactorer = "Boiler Manufacturer 2",
                    Name = "Boiler name 2",
                    Power = 15,
                    Price = 20.2,
                    Type = BoilerType.InderectHeatingBoiler,
                    WaterCapacity = 400,
                    WithFullnessIndicators = true
                },
                new Boiler
                {
                    Id = 3,
                    Manufactorer = "Boiler Manufacturer 3",
                    Name = "Boiler name 3",
                    Power = 12,
                    Price = 16.2,
                    Type = BoilerType.InderectHeatingBoiler,
                    WaterCapacity = 300,
                    WithFullnessIndicators = true
                }
            };
        }
    }
}
