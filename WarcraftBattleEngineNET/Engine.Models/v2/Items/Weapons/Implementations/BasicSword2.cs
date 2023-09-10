using Engine.Models.Actors;
using Engine.Models.v2.Actors;

namespace Engine.Models.v2.Items.Weapons.Implementations
{
  public class BasicSword2 : WeaponItem
  {
    public BasicSword2() : base(WeaponSlot.MainHand)
    {
    }

    public override void AddTo(Actor2 context)
    {
      context.WeaponItems.Add(this);
      context.AttackModifiers.Add(this);
    }

    public override Stats Modify(Stats stats)
    {
      return stats.Merge(new Stats(strength: 5, stamina: 6));
    }

    public override void Modify()
    {
    }
  }
}
