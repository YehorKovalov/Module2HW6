using ElectricalAppliancesIHierarchy.Models.FoodRelatedAppliances;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;

namespace ElectricalAppliancesIHierarchy.Services
{
    public class ElectricalFoodGrinderServices
    {
        private readonly IElectricalFoodGrinderProvider _grinderProvider;
        public ElectricalFoodGrinderServices(IElectricalFoodGrinderProvider grinderProvider)
        {
            _grinderProvider = grinderProvider;
        }

        public ElecticalFoodGrinderDTO[] GetGrinerDTOs()
        {
            var grindersFromProvider = _grinderProvider.GetElecticalFoodGrinders();
            if (grindersFromProvider == null)
            {
                return null;
            }

            var i = 0;
            var resultGrinders = new ElecticalFoodGrinderDTO[grindersFromProvider.Length];
            foreach (var grinder in grindersFromProvider)
            {
                resultGrinders[i++] = new ElecticalFoodGrinderDTO
                {
                    Id = grinder.Id,
                    Manufactorer = grinder.Manufactorer,
                    Name = grinder.Name,
                    Power = grinder.Power,
                    Price = grinder.Price,
                    FoodForCooking = grinder.FoodForCooking,
                    PossibleAttachmentType = grinder.PossibleAttachmentType
                };
            }

            return resultGrinders;
        }
    }
}
