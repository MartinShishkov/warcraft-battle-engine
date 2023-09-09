using Engine.Models.Actors;

namespace Engine.Models.Buffs
{
  public abstract class Buff : IStatsModifier, IEquatable<Buff>
  {
    protected readonly string _identifier;

    protected Buff(string identifier)    {
      _identifier = identifier;
    }

    public string Identifier => this._identifier;

    public bool Equals(Buff? other)
    {
      if (ReferenceEquals(null, other))
        return false;

      return this._identifier == other._identifier;
    }

    public abstract Stats Modify(Stats context);
    public abstract BuffCollection On(BuffCollection buffs);
  }
}
