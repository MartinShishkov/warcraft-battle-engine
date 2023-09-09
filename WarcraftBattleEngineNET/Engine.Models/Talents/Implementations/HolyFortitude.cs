using Engine.Models.Actors;
using Engine.Models.Buffs;
using Engine.Models.Buffs.Implementations;
using Engine.Models.Util;

namespace Engine.Models.Talents.Implementations
{
  /// <summary>
  /// Increases the stamina bonus of "Power Word: Fortitude" buff by 1%, 2% or 3% of total intellect depending
  /// on the level of the talent.
  /// </summary>
  public class HolyFortitude : Talent
  {
    private readonly int _rank;
    private static readonly int MAX_LEVEL = 3;

    public HolyFortitude(int rank = 1) : base("HOLY_FORTITUDE")
    {
      _rank = Math.Min(rank, MAX_LEVEL);
    }

    public override Stats Modify(Stats stats)
    {
      return stats;
    }

    public override Buff Modify(Buff buff)
    {
      if (!buff.Identifier.Contains("POWER_WORD_FORTITUDE")) {
        return buff;
      }

      return new PowerWordFortitudeDecorator(buff as PowerWordFortitude, _rank);
    }
  }
}
