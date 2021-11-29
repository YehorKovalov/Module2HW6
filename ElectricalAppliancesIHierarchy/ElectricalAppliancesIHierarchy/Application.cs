using System;
using ElectricalAppliancesIHierarchy.Services.Abstractions;
using ElectricalAppliancesIHierarchy.UI.Abstractions;

namespace ElectricalAppliancesIHierarchy
{
    public class Application
    {
        private readonly IElectricalApplianceServices _applianceServices;
        private readonly IUI _ui;
        public Application(
            IElectricalApplianceServices applianceServices,
            IUI uI)
        {
            _applianceServices = applianceServices;
            _ui = uI;
        }

        public void Run()
        {
            var appliances = _applianceServices.GetAppliances();
            _ui.DisplayMessage("All appliances: ");
            _ui.DisplayElectricalAppliances(appliances);

            var sortingResult = _applianceServices.SortAppliancesByPower(appliances);
            _ui.DisplayMessage("Sorted appliances: ");
            _ui.DisplayElectricalAppliances(sortingResult);

            var findingResult = _applianceServices.FindFirstByPowerInRangeOrNull(appliances, 200, 220);
            _ui.DisplayMessage("Found appliance which power is in range 200...220: ");
            _ui.DisplayAppliance(findingResult);

            _applianceServices.PlugInPlugableAppliances(appliances);
            _ui.DisplayPlagableInAppliances(appliances);
        }
    }
}