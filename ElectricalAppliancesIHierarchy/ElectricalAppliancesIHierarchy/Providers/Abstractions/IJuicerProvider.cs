using ElectricalAppliancesIHierarchy.Domain.Entities;

namespace ElectricalAppliancesIHierarchy.Providers.Abstractions
{
    public interface IJuicerProvider
    {
        Juicer[] GetJuicers();
    }
}