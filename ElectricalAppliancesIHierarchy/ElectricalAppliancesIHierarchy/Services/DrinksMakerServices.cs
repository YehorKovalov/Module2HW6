using ElectricalAppliancesIHierarchy.Models.FoodRelatedAppliances;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Services
{
    public class DrinksMakerServices
    {
        private readonly IDrinksMakerProvider _drinksMakerProvider;
        public DrinksMakerServices(IDrinksMakerProvider drinksMakerProvider)
        {
            _drinksMakerProvider = drinksMakerProvider;
        }

        public DrinksMakerDTO[] GetDrinkMakersDTOs()
        {
            var drinkMakersFromProvider = _drinksMakerProvider.GetDrinksMakers();
            if (drinkMakersFromProvider == null)
            {
                return null;
            }

            var i = 0;
            var resultdrinksMakers = new DrinksMakerDTO[drinkMakersFromProvider.Length];
            foreach (var drinksMaker in drinkMakersFromProvider)
            {
                resultdrinksMakers[i++] = new DrinksMakerDTO
                {
                    Id = drinksMaker.Id,
                    Manufactorer = drinksMaker.Manufactorer,
                    Name = drinksMaker.Name,
                    PluggedIn = drinksMaker.PluggedIn,
                    Power = drinksMaker.Power,
                    Price = drinksMaker.Price,
                    FoodForCooking = drinksMaker.FoodForCooking,
                    RequiresControl = drinksMaker.RequiresControl
                };
            }

            return resultdrinksMakers;
        }
    }
}
