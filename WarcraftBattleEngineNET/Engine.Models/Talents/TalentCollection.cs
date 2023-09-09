using Engine.Models.Actors;
using Engine.Models.Talents;

namespace Engine.Models.Buffs
{
  public class TalentCollection
  {
    private readonly Dictionary<string, Talent> _store;

    public TalentCollection()
    {
      this._store = new Dictionary<string, Talent>();
    }

    public void Add(Talent talent)
    {
      this._store[talent.Identifier] = talent;
    }

    public void Remove(string[] identifiers)
    {
      foreach(var id in identifiers)
      {
        this._store.Remove(id);
      }
    }

    public void Remove(string identifier)
    {
      this._store.Remove(identifier);
    }

    public bool Has(Talent buff)
    {
      return this._store.ContainsKey(buff.Identifier);
    }

    public bool Has(string identifier)
    {
      return this._store.ContainsKey(identifier);
    }

    public Stats Apply(Stats stats)
    {
      var agg = stats;
      foreach (var kv in _store)
      {
        var talent = kv.Value;
        agg = talent.Modify(agg);
      }

      return agg;
    }
  }
}
