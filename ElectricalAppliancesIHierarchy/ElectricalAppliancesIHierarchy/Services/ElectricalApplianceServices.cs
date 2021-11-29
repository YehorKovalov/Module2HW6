using ElectricalAppliancesIHierarchy.Helpers;
using ElectricalAppliancesIHierarchy.Models;
using ElectricalAppliancesIHierarchy.Services.Abstractions;

namespace ElectricalAppliancesIHierarchy.Services
{
    public class ElectricalApplianceServices : IElectricalApplianceServices
    {
        private readonly DrinksMakerServices _drinksMakerServices;
        private readonly BoilerServices _boilerServices;
        private readonly ElectricalFoodGrinderServices _grinderServices;
        private readonly JuicerServices _juicerServices;
        private readonly ElectricKettleServices _kettleServices;
        private readonly ISocketServices _socketServices;
        private ElectricalAppliance[] _appliances;
        public ElectricalApplianceServices(
            ISocketServices socketServices,
            DrinksMakerServices drinksMakerServices,
            BoilerServices boilerServices,
            JuicerServices juicerServices,
            ElectricKettleServices kettleServices,
            ElectricalFoodGrinderServices grinderServices)
        {
            _drinksMakerServices = drinksMakerServices;
            _boilerServices = boilerServices;
            _juicerServices = juicerServices;
            _kettleServices = kettleServices;
            _grinderServices = grinderServices;
            _appliances = GetAll();
            _socketServices = socketServices;
        }

        public ElectricalAppliance[] GetAppliances()
        {
            return _appliances;
        }

        public ElectricalAppliance[] SortAppliancesByPower(ElectricalAppliance[] appliances)
        {
            return appliances?.SortAppliances(new AppliancesPowerComparer());
        }

        public ElectricalAppliance FindFirstByPowerInRangeOrNull(
            ElectricalAppliance[] appliances,
            int minPower,
            int maxPower)
        {
            return appliances?.FindFirstInRangeOrNull(minPower, maxPower);
        }

        public void PlugInPlugableAppliances(ElectricalAppliance[] appliances)
        {
            foreach (var appliance in appliances)
            {
                if (appliance is IPlugableIn plugable)
                {
                    _socketServices.PlugInElectricalAppliance(plugable);
                }
            }
        }

        private ElectricalAppliance[] GetAll()
        {
            var drinksMakers = _drinksMakerServices.GetDrinkMakersDTOs();
            var boilers = _boilerServices.GetBoilerDTOs();
            var kettles = _kettleServices.GetKettleDTOs();
            var grinders = _grinderServices.GetGrinerDTOs();
            var juicers = _juicerServices.GetJuicerDTOs();
            var result = drinksMakers
                .AppendRange(boilers)
                .AppendRange(kettles)
                .AppendRange(grinders)
                .AppendRange(juicers);

            return result;
        }
    }
}
