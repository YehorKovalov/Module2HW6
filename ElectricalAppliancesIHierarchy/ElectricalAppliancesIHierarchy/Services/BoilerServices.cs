using ElectricalAppliancesIHierarchy.Models.WaterHeaterAppliances;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Services
{
    public class BoilerServices
    {
        private readonly IBoilerProvider _boilerProvider;
        public BoilerServices(IBoilerProvider boilerProvider)
        {
            _boilerProvider = boilerProvider;
        }

        public BoilerDTO[] GetBoilerDTOs()
        {
            var boilersFromProvider = _boilerProvider.GetBoilers();
            if (boilersFromProvider == null)
            {
                return null;
            }

            var i = 0;
            var resultBoilers = new BoilerDTO[boilersFromProvider.Length];
            foreach (var boiler in boilersFromProvider)
            {
                resultBoilers[i++] = new BoilerDTO
                {
                    Id = boiler.Id,
                    Manufactorer = boiler.Manufactorer,
                    WithFullnessIndicators = boiler.WithFullnessIndicators,
                    Name = boiler.Name,
                    Power = boiler.Power,
                    Price = boiler.Price,
                    Type = boiler.Type,
                    WaterCapacity = boiler.WaterCapacity
                };
            }

            return resultBoilers;
        }
    }
}
