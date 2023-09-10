using Engine.Models.Actors;
using Engine.Models.v2;

namespace Engine.Models
{
  public interface IStatsModifier2
  {
    Stats Modify(Stats stats);
  }
}
