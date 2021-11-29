using System;
using ElectricalAppliancesIHierarchy.Models;
using ElectricalAppliancesIHierarchy.UI.Abstractions;

namespace ElectricalAppliancesIHierarchy.UI
{
    public class ConsoleManager : IUI
    {
        public void DisplayAppliance(ElectricalAppliance appliance)
        {
            var id = appliance.Id;
            var manufacturer = appliance.Manufactorer;
            var name = appliance.Name;
            var power = appliance.Power;
            var price = appliance.Price;
            Console.WriteLine($"Id: {id}, name: {name}, manufacturer: " +
                $"{manufacturer}, power: {power}, price: {price}");
        }

        public void DisplayElectricalAppliances(ElectricalAppliance[] appliances)
        {
            foreach (var appliance in appliances)
            {
                DisplayAppliance(appliance);
            }
        }

        public void DisplayPlagableInAppliances(ElectricalAppliance[] electricalAppliances)
        {
            DisplayMessage("Plug in all appliances");
            foreach (var appliance in electricalAppliances)
            {
                if (appliance is IPlugableIn plugableIn)
                {
                    DisplayAppliance(appliance);
                    Console.Write($"{plugableIn.PluggedIn}");
                    Console.WriteLine();
                }
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
