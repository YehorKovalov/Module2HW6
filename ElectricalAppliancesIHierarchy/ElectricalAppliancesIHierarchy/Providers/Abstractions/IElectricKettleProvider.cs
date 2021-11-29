using ElectricalAppliancesIHierarchy.Domain.Entities;

namespace ElectricalAppliancesIHierarchy.Providers.Abstractions
{
    public interface IElectricKettleProvider
    {
        ElectricKettle[] GetElectricKettles();
    }
}