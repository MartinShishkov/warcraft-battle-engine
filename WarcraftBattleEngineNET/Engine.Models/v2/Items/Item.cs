using Engine.Models.Actors;
using Engine.Models.v2.Actors;

namespace Engine.Models.v2.Items
{
  public abstract class Item : IStatsModifier2, IAddable
  {
    // Name
    // Rarity
    // Required level
    public abstract void AddTo(Actor2 context);

    public abstract Stats Modify(Stats stats);
  }
}
