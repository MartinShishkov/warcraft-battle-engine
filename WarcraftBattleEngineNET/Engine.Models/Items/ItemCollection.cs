using Engine.Models.Actors;

namespace Engine.Models.Items
{
  public class ItemCollection
  {
    private readonly Dictionary<ItemSlot, Item> _store;

    public ItemCollection()
    {
      this._store = new Dictionary<ItemSlot, Item>();
    }

    public void Add(Item item)
    {
      this._store[item.Slot] = item;
    }

    public void Remove(ItemSlot slot)
    {
      this._store.Remove(slot);
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
