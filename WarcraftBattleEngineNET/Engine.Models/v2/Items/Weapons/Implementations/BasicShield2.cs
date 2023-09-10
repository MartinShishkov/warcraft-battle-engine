using Engine.Models.Actors;
using Engine.Models.v2.Actors;

namespace Engine.Models.v2.Items.Weapons.Implementations
{
  public class BasicShield2 : WeaponItem
  {
    public BasicShield2() : base(WeaponSlot.OffHand)
    {
    }

    public override void AddTo(Actor2 context)
    {
      context.WeaponItems.Add(this);
    }

    public override Stats Modify(Stats stats)
    {
      return stats.Merge(new Stats(armor: 100));
    }

    public override void Modify()
    {
    }
  }
}
