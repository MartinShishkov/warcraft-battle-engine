using Engine.Models.Actors;

namespace Engine.Models.Buffs.Implementations
{
  // "Power Word: Fortitude" is a stackable buff,
  // so we can represent this in the code like a linked list
  public class PowerWordFortitude : Buff
  {
    private readonly PowerWordFortitude? _next;
    private readonly int _level;

    public PowerWordFortitude(int level = 1, PowerWordFortitude? next = null) : base($"POWER_WORD_FORTITUDE_{level}")
    {
      _level = Math.Min(level, 3);
      this._next = next;
    }

    public int Effect { 
      get
      {
        return 15 * _level;
      }
    }

    public override Stats Modify(Stats stats)
    {
      if (_next == null)
      {
        return stats.Merge(new Stats(stamina: Effect));
      }

      return this._next.Modify(stats).Merge(new Stats(stamina: Effect));
    }

    public override BuffCollection On(BuffCollection buffs)
    {
      var copy = buffs.Clone();
      var existing = copy.Get(Identifier);

      if (existing != null)
      {
        var newFortitude = new PowerWordFortitude(
          _level, 
          existing as PowerWordFortitude
        );
        copy.Remove(Identifier);
        copy.Add(newFortitude);
      }
      else
      {
        copy.Add(this);
      }

      return copy;
    }
  }
}
