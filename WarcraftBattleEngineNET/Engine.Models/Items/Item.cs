using Engine.Models.Actors;

namespace Engine.Models.Items
{
  /// <summary>
  /// Some items, Weapons to be precise, modify not only the stats
  /// but also an attack. How should we go about this without having to
  /// add a method for modifying an attack to each item implementation?
  /// </summary>
  public abstract class Item : IStatsModifier
  {
    protected Item(ItemSlot slot, Stats stats)
    {
      Slot = slot;
      Stats = stats;
    }

    public ItemSlot Slot { get; set; }

    protected Stats Stats { get; }

    public Stats Modify(Stats stats)
    {
      return stats.Merge(this.Stats);
    }
  }
}
