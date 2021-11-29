using ElectricalAppliancesIHierarchy.Domain.Entities;

namespace ElectricalAppliancesIHierarchy.Providers.Abstractions
{
    public interface IDrinksMakerProvider
    {
        DrinksMaker[] GetDrinksMakers();
    }
}