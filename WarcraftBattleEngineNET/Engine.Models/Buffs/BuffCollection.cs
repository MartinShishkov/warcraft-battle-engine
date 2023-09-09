using Engine.Models.Actors;

namespace Engine.Models.Buffs
{
  public class BuffCollection
  {
    private readonly Dictionary<string, Buff> _store;
    private readonly List<IBuffModifier> _modifiers;

    public BuffCollection()
    {
      this._store = new Dictionary<string, Buff>();
      this._modifiers = new List<IBuffModifier>();
    }

    public BuffCollection(ICollection<Buff> buffs, List<IBuffModifier> modifiers) {
      this._store = buffs.ToDictionary(entry => entry.Identifier, entry => entry);
      this._modifiers = modifiers ?? new List<IBuffModifier>();
    }

    public void Add(Buff buff)
    {
      this._store[buff.Identifier] = buff;
    }

    public void Add(IBuffModifier modifier)
    {
      this._modifiers.Add(modifier);
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

    public bool Has(Buff buff)
    {
      return this._store.ContainsKey(buff.Identifier);
    }

    public bool Has(string identifier)
    {
      return this._store.ContainsKey(identifier);
    }

    public Buff? Get(string identifier)
    {
      if (!this._store.ContainsKey(identifier))
      {
        return null;
      }

      return (Buff?)this._store[identifier];
    }

    public BuffCollection Clone()
    {
      return new BuffCollection(this._store.Values, this._modifiers);
    }

    public Stats Apply(Stats stats)
    {
      var agg = stats;
      foreach (var kv in _store)
      {
        var buff = kv.Value;
        var modified = buff;
        foreach (var modifier in _modifiers)
        {
          modified = modifier.Modify(modified);
        }

        agg = modified.Modify(agg);
      }

      return agg;
    }
  }
}
