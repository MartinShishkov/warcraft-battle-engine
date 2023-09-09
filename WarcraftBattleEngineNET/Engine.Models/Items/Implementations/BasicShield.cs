using Engine.Models.Actors;

namespace Engine.Models.Items.Implementations
{
  public class BasicShield : Item
  {
    public BasicShield(int level = 1) : base(
      ItemSlot.OffHand,
      new Stats(armor: 100 * level)
    )
    { }
  }
}
