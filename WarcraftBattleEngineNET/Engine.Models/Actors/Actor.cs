using Engine.Models.Buffs;
using Engine.Models.Items;
using Engine.Models.Talents;

namespace Engine.Models.Actors
{
  public class Actor
  {
    private Stats _initialStats;
    private ItemCollection _items;
    private TalentCollection _talents;
    private BuffCollection _buffs;
    private List<IAttackModifier> _attackModifiers;

    public Actor(Stats? stats = null)
    {
      this._items = new ItemCollection();
      this._buffs = new BuffCollection();
      this._talents = new TalentCollection();
      this._initialStats = stats ?? new Stats();
      this._attackModifiers = new List<IAttackModifier>();
    }

    public int Armor => Stats.Armor;
    public int Strength => Stats.Strength;
    public int Stamina => Stats.Stamina;
    public int Intellect => Stats.Intellect;
    public int TotalHealthPoints => Stats.Stamina * 10;
    public int TotalManaPoints => Stats.Intellect * 10;

    public Stats Stats
    {
      get
      {
        var stats = this._initialStats;
        stats = this._items.Apply(stats);
        stats = this._talents.Apply(stats);
        stats = this._buffs.Apply(stats);

        return stats;
      }
    }

    public Actor Add(Weapon weapon)
    {
      this._items.Add(weapon);
      this._attackModifiers.Add(weapon);
      return this;
    }

    public Actor Add(Item item)
    {
      this._items.Add(item);
      return this;
    }

    public Actor Add(Buff buff)
    {
      var buffs = buff.On(this._buffs);
      this._buffs = buffs;
      return this;
    }

    public Actor Add(Talent talent)
    {
      // TODO: Prevent the same talent from being added twice
      // Talents should only go up in level, somewhat like the buffs
      this._talents.Add(talent);
      this._buffs.Add(talent);
      return this;
    }
  }
}
