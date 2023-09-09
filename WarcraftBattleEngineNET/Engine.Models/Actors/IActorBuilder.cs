using Engine.Models.Buffs;
using Engine.Models.Items;
using Engine.Models.Talents;

namespace Engine.Models.Actors
{
  public interface IActorBuilder
  {
    IActorBuilder Add(Item item);
    IActorBuilder Add(Talent item);
    IActorBuilder Add(Buff item);
    Actor Build();
  }
}
