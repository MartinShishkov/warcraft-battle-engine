using Engine.Models.Actors;
using Engine.Models.Buffs.Implementations;
using Engine.Models.Talents.Implementations;

namespace Engine.Tests
{
  [TestClass]
  public class TalentTests
  {
    [TestMethod]
    public void IronSkinShouldHaveNoEffectOnInitialActor()
    {
      var talent = new IronSkin();
      var actor = new Actor();
      actor.Add(talent);
      
      Assert.AreEqual(0, actor.Armor);
      Assert.AreEqual(0, actor.Strength);
      Assert.AreEqual(0, actor.Stamina);
    }

    [TestMethod]
    public void IronSkinShouldIncreaseArmorWith5Percent()
    {
      var talent = new IronSkin();
      var actor = new Actor(new Stats(armor: 100));
      actor.Add(talent);

      Assert.AreEqual(105, actor.Armor);
      Assert.AreEqual(0, actor.Strength);
      Assert.AreEqual(0, actor.Stamina);
    }

    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 2)]
    [DataRow(3, 3)]
    [DataRow(4, 3)]
    public void HolyFortitudeShouldIncreaseTheEffectOfPowerWordFortitude(int level, int bonus)
    {
      var buff = new PowerWordFortitude();
      var talent = new HolyFortitude(level);
      var actor = new Actor(new Stats(intellect: 100));
      actor.Add(buff);
      Assert.AreEqual(15, actor.Stamina);

      actor.Add(talent);
      Assert.AreEqual(15 + bonus, actor.Stamina);

      actor.Add(buff);
      Assert.AreEqual((15 * 2) + bonus, actor.Stamina);

      Assert.AreEqual(0, actor.Armor);
      Assert.AreEqual(0, actor.Strength);
      Assert.AreEqual(100, actor.Intellect);
    }
  }
}