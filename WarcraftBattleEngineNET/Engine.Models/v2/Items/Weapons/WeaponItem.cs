namespace Engine.Models.v2.Items.Weapons
{
  public abstract class WeaponItem : Item, IStatsModifier2, IAttackModifier2
  {
    protected WeaponItem(WeaponSlot slot)
    {
      Slot = slot;
    }

    public WeaponSlot Slot { get; }

    public abstract void Modify();

    // Weapon type - Sword, axe, staff, mace, etc.
  }
}
