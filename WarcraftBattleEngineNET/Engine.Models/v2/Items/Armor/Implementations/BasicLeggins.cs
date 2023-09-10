using Engine.Models.Actors;
using Engine.Models.v2.Actors;

namespace Engine.Models.v2.Items.Armor.Implementations
{
  public class BasicLeggins : ArmorItem
  {
    public BasicLeggins() : base(ArmorSlot.Legs)
    {
    }

    public override void AddTo(Actor2 context)
    {
      context.ArmorItems.Add(this);
    }

    public override Stats Modify(Stats stats)
    {
      return stats.Merge(new Stats(armor: 20, stamina: 1));
    }
  }
}
