namespace Engine.Models.Actors
{
  public class Stats
  {
    public int Stamina { get; set; }
    public int Intellect { get; set; }
    public int Strength { get; set; }
    public int Armor { get; set; }

    public Stats(int stamina = 0, int strength = 0, int armor = 0, int intellect = 0) { 
      this.Stamina = stamina;
      this.Strength = strength;
      this.Armor = armor;
      this.Intellect = intellect;
    }

    public Stats Merge(Stats other)
    {
      return new Stats()
      {
        Armor = other.Armor + this.Armor,
        Strength = other.Strength + this.Strength,
        Stamina = other.Stamina + this.Stamina,
        Intellect = other.Intellect + this.Intellect
      };
    }
  }
}
