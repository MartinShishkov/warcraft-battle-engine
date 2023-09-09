using Engine.Models.Actors;

namespace Engine.Models.Buffs.Implementations
{
  public class AspectOfTheWild : Buff
  {
    private static string[] Incompatibles = new string[]
    {
      "ASPECT_OF_NATURE_1",
      "ASPECT_OF_NATURE_2",
      "ASPECT_OF_NATURE_3",
      "ASPECT_OF_THE_WILD_1",
      "ASPECT_OF_THE_WILD_2",
      "ASPECT_OF_THE_WILD_3",
    };

    private readonly int _level;
    private static readonly int MAX_LEVEL = 3;

    public AspectOfTheWild(int level = 1) : base($"ASPECT_OF_THE_WILD_{level}")
    {
      _level = Math.Min(level, MAX_LEVEL);
    }

    public override Stats Modify(Stats stats)
    {
      return stats.Merge(new Stats(10 * _level, 10 * _level, _level * 10));
    }

    public override BuffCollection On(BuffCollection buffs)
    {
      var copy = buffs.Clone();
      copy.Remove(Incompatibles);
      copy.Add(this);

      return copy;
    }
  }
}
