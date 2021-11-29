using System;
using ElectricalAppliancesIHierarchy.Providers;
using ElectricalAppliancesIHierarchy.Providers.Abstractions;
using ElectricalAppliancesIHierarchy.Services;
using ElectricalAppliancesIHierarchy.Services.Abstractions;
using ElectricalAppliancesIHierarchy.UI;
using ElectricalAppliancesIHierarchy.UI.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ElectricalAppliancesIHierarchy
{
    public class Startup
    {
        public void Run()
        {
            var serviceProvider = ConfigureServices();
            var app = serviceProvider?.GetService<Application>();
            app?.Run();
        }

        private IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IElectricalApplianceServices, ElectricalApplianceServices>();
            serviceCollection.AddTransient<IBoilerProvider, BoilerProvider>();
            serviceCollection.AddTransient<IDrinksMakerProvider, DrinksMakerProvider>();
            serviceCollection.AddTransient<IElectricalFoodGrinderProvider, ElectricalFoodGrinderProvider>();
            serviceCollection.AddTransient<IElectricKettleProvider, ElectricKettleProvider>();
            serviceCollection.AddTransient<IJuicerProvider, JuicerProvider>();
            serviceCollection.AddTransient<ISocketServices, SocketServices>();
            serviceCollection.AddTransient<IUI, ConsoleManager>();
            serviceCollection.AddTransient<DrinksMakerServices>();
            serviceCollection.AddTransient<BoilerServices>();
            serviceCollection.AddTransient<ElectricalFoodGrinderServices>();
            serviceCollection.AddTransient<ElectricKettleServices>();
            serviceCollection.AddTransient<JuicerServices>();
            serviceCollection.AddTransient<Application>();
            return serviceCollection.BuildServiceProvider();
        }
    }
}
