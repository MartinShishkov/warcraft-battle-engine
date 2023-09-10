namespace Engine.Models.v2.Items.Armor
{
  public abstract class ArmorItem : Item
  {
    protected ArmorItem(ArmorSlot slot)
    {
      Slot = slot;
    }

    public ArmorSlot Slot { get; }
    // Armor type - Cloth, Leather, Mail, Plate, None
  }
}
