using ElectricalAppliancesIHierarchy.Models.FoodRelatedAppliances;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Services
{
    public class JuicerServices
    {
        private readonly IJuicerProvider _juicerProvider;

        public JuicerServices(IJuicerProvider juicerProvider)
        {
            _juicerProvider = juicerProvider;
        }

        public JuicerDTO[] GetJuicerDTOs()
        {
            var juicersFromProvider = _juicerProvider.GetJuicers();
            if (juicersFromProvider == null)
            {
                return null;
            }

            var i = 0;
            var resultJuicers = new JuicerDTO[juicersFromProvider.Length];
            foreach (var juicer in juicersFromProvider)
            {
                resultJuicers[i++] = new JuicerDTO
                {
                    Id = juicer.Id,
                    Manufactorer = juicer.Manufactorer,
                    Name = juicer.Name,
                    Power = juicer.Power,
                    Price = juicer.Price,
                    FoodForCooking = juicer.FoodForCooking,
                    PossibleJuiceFromProductPercent = juicer.PossibleJuiceFromProductPercent
                };
            }

            return resultJuicers;
        }
    }
}
