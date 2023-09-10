using Engine.Models.Actors;
using Engine.Models.v2.Items.Armor;
using Engine.Models.v2.Items.Weapons;

namespace Engine.Models.v2.Actors
{
  public class Actor2
  {
    private Stats _initialStats;
    public ArmorCollection ArmorItems;
    public WeaponCollection WeaponItems;
    public List<IStatsModifier2> Talents;
    public List<IStatsModifier2> Buffs;
    public List<IAttackModifier2> AttackModifiers;

    public Actor2(Stats? stats = null)
    {
      this._initialStats = stats ?? new Stats();
      this.ArmorItems = new ArmorCollection();
      this.WeaponItems = new WeaponCollection();
      this.Talents = new List<IStatsModifier2>();
      this.Buffs = new List<IStatsModifier2>();
      this.AttackModifiers = new List<IAttackModifier2>();
    }

    public int Armor => Stats.Armor;
    public int Strength => Stats.Strength;
    public int Stamina => Stats.Stamina;
    public int Intellect => Stats.Intellect;
    public int TotalHealthPoints => Stats.Stamina * 10;
    public int TotalManaPoints => Stats.Intellect * 10;

    private List<IStatsModifier2> Items
    {
      get
      {
        var agg = new List<IStatsModifier2>();
        agg.AddRange(this.ArmorItems.All);
        agg.AddRange(this.WeaponItems.All);
        return agg;
      }
    }

    public Stats Stats
    {
      get
      {
        var stats = this._initialStats;
        stats = this.ArmorItems.Apply(stats);
        stats = this.WeaponItems.Apply(stats);

        return stats;
      }
    }

    public Actor2 Add(IAddable modifier)
    {
      modifier.AddTo(this);
      return this;
    }
  }
}
