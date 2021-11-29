using ElectricalAppliancesIHierarchy.Domain.Entities;

namespace ElectricalAppliancesIHierarchy.Providers.Abstractions
{
    public interface IElectricalFoodGrinderProvider
    {
        ElecticalFoodGrinder[] GetElecticalFoodGrinders();
    }
}