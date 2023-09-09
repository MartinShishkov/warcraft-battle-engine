using Engine.Models.Actors;

namespace Engine.Models
{
  internal interface IStatsModifier
  {
    Stats Modify(Stats stats);
  }
}
