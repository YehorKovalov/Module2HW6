using ElectricalAppliancesIHierarchy.Domain.Entities;

namespace ElectricalAppliancesIHierarchy.Providers.Abstractions
{
    public interface IBoilerProvider
    {
        Boiler[] GetBoilers();
    }
}