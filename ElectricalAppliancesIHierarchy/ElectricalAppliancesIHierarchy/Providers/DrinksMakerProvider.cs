using ElectricalAppliancesIHierarchy.Domain.Entities;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Providers
{
    public class DrinksMakerProvider : IDrinksMakerProvider
    {
        public DrinksMaker[] GetDrinksMakers()
        {
            return new DrinksMaker[]
            {
                new DrinksMaker
                {
                    Id = 1,
                    FoodForCooking = "Cacao",
                    Manufactorer = "Drinks manker manufacturer 1",
                    Name = "Drink maker 1",
                    Power = 300,
                    Price = 100.1,
                    RequiresControl = false
                },
                new DrinksMaker
                {
                    Id = 2,
                    FoodForCooking = "Coffee",
                    Manufactorer = "Drinks manker manufacturer 2",
                    Name = "Drink maker 2",
                    Power = 500,
                    Price = 20.1,
                    RequiresControl = false
                },
                new DrinksMaker
                {
                    Id = 3,
                    FoodForCooking = "Tea",
                    Manufactorer = "Drinks manker manufacturer 3",
                    Name = "Drink maker 3",
                    Power = 200,
                    Price = 200.2,
                    RequiresControl = true
                }
            };
        }
    }
}
