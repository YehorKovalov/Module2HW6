using ElectricalAppliancesIHierarchy.Domain.Entities;
using ElectricalAppliancesIHierarchy.Models.WaterHeaterAppliances;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Providers
{
    public class ElectricKettleProvider : IElectricKettleProvider
    {
        public ElectricKettle[] GetElectricKettles()
        {
            return new ElectricKettle[]
            {
                new ElectricKettle
                {
                    Id = 1,
                    Manufactorer = "Electric Kettle Manufacturer 1",
                    Name = "Electric Kettle name 1",
                    OpeningLidPrinciple = OpeningLidPrinciple.Automatic,
                    Power = 10.2,
                    Price = 100.2,
                    WaterCapacity = 900,
                    WithFullnessIndicators = true
                },
                new ElectricKettle
                {
                    Id = 1,
                    Manufactorer = "Electric Kettle Manufacturer 1",
                    Name = "Electric Kettle name 1",
                    OpeningLidPrinciple = OpeningLidPrinciple.Automatic,
                    Power = 10.2,
                    Price = 100.2,
                    WaterCapacity = 900,
                    WithFullnessIndicators = true
                }
            };
        }
    }
}
