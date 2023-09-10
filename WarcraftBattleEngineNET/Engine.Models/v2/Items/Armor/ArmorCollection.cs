using Engine.Models.Actors;

namespace Engine.Models.v2.Items.Armor
{
  public class ArmorCollection
  {
    private readonly Dictionary<ArmorSlot, ArmorItem> _store;

    public ArmorCollection()
    {
      _store = new Dictionary<ArmorSlot, ArmorItem>();
    }

    public IEnumerable<IStatsModifier2> All => this._store.Values;

    public void Add(ArmorItem item)
    {
      _store[item.Slot] = item;
    }

    public void Remove(ArmorSlot slot)
    {
      _store.Remove(slot);
    }

    public Stats Apply(Stats stats)
    {
      foreach (var kv in _store)
      {
        var item = kv.Value;
        stats = item.Modify(stats);
      }

      return stats;
    }
  }
}
