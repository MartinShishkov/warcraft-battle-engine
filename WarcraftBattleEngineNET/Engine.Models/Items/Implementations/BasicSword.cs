using Engine.Models.Actors;

namespace Engine.Models.Items.Implementations
{
  public class BasicSword : Weapon
  {
    public BasicSword() : base(ItemSlot.MainHand, new Stats(strength: 10))
    {
    }
  }
}
