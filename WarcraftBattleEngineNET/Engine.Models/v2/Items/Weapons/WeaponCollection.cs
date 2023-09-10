using Engine.Models.Actors;

namespace Engine.Models.v2.Items.Weapons
{
  public class WeaponCollection
  {
    private readonly Dictionary<WeaponSlot, WeaponItem> _store;

    public WeaponCollection()
    {
      this._store = new Dictionary<WeaponSlot, WeaponItem>();
    }

    public IEnumerable<WeaponItem> All => this._store.Values;

    public void Add(WeaponItem item)
    {
      // TODO: Improve the logic here
      // when adding a Two-hand item
      this._store[item.Slot] = item;
    }

    public void Remove(WeaponSlot slot)
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
