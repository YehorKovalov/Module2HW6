using ElectricalAppliancesIHierarchy.Models.WaterHeaterAppliances;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Services
{
    public class ElectricKettleServices
    {
        private readonly IElectricKettleProvider _kettleProvider;

        public ElectricKettleServices(IElectricKettleProvider kettleProvider)
        {
            _kettleProvider = kettleProvider;
        }

        public ElectricKettleDTO[] GetKettleDTOs()
        {
            var kettlesFromProvider = _kettleProvider.GetElectricKettles();
            if (kettlesFromProvider == null)
            {
                return null;
            }

            var i = 0;
            var resultKettles = new ElectricKettleDTO[kettlesFromProvider.Length];
            foreach (var kettle in kettlesFromProvider)
            {
                resultKettles[i++] = new ElectricKettleDTO
                {
                    Id = kettle.Id,
                    Manufactorer = kettle.Manufactorer,
                    Name = kettle.Name,
                    Power = kettle.Power,
                    Price = kettle.Price,
                    OpeningLidPrinciple = kettle.OpeningLidPrinciple,
                    PluggedIn = kettle.PluggedIn,
                    WaterCapacity = kettle.WaterCapacity,
                    WithFullnessIndicators = kettle.WithFullnessIndicators
                };
            }

            return resultKettles;
        }
    }
}
