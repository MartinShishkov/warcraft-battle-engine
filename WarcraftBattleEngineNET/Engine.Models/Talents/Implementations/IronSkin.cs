using Engine.Models.Actors;
using Engine.Models.Buffs;
using Engine.Models.Util;

namespace Engine.Models.Talents.Implementations
{
  public class IronSkin : Talent
  {
    public IronSkin() : base("IRON_SKIN")
    {
    }

    public override Stats Modify(Stats stats)
    {
      var armor = stats.Armor + Percentage.From(5, stats.Armor);
      return new Stats(stamina: stats.Stamina, strength: stats.Strength, armor);
    }

    public override Buff Modify(Buff buff)
    {
      return buff;
    }
  }
}
