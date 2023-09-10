using Engine.Models.Actors;
using Engine.Models.v2.Actors;

namespace Engine.Models.v2.Buffs
{
  public class AspectOfNature2 : IStatsModifier2
  {
    public void AddTo(Actor2 context)
    {
      context.Buffs.Add(this);
    }

    public Stats Modify(Stats stats)
    {
      return stats.Merge(new Stats(stamina: 15 * 1));
    }
  }
}
