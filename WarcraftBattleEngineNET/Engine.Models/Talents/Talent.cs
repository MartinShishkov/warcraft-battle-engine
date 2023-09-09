using Engine.Models.Actors;
using Engine.Models.Buffs;

namespace Engine.Models.Talents
{
  
  public abstract class Talent : IStatsModifier, IBuffModifier, IEquatable<Talent>
  {
    protected readonly string _identifier;

    protected Talent(string identifier)
    {
      _identifier = identifier;
    }

    public string Identifier => this._identifier;

    public bool Equals(Talent? other)
    {
      if (ReferenceEquals(null, other))
        return false;

      return this._identifier == other._identifier;
    }

    public abstract Stats Modify(Stats stats);
    public abstract Buff Modify(Buff buff);
  }
}
