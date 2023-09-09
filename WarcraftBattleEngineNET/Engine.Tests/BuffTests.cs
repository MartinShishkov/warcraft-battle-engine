using Engine.Models.Actors;
using Engine.Models.Buffs;
using Engine.Models.Buffs.Implementations;
using Engine.Models.Items;

namespace Engine.Tests
{
  [TestClass]
  public class BuffTests
  {
    [TestMethod]
    public void AspectOfTheWildTest()
    {
      var buff = new AspectOfTheWild();
      var actor = new Actor();
      actor.Add(buff);
      
      Assert.AreEqual(10, actor.Armor);
      Assert.AreEqual(10, actor.Strength);
      Assert.AreEqual(10, actor.Stamina);
    }

    [TestMethod]
    public void ShouldNotBeAbleToApplyAspectOfTheWildTwice()
    {
      var buff = new AspectOfTheWild();
      var actor = new Actor();
      actor
          .Add(buff)
          .Add(buff);

      Assert.AreEqual(10, actor.Armor);
      Assert.AreEqual(10, actor.Strength);
      Assert.AreEqual(10, actor.Stamina);
    }

    [TestMethod]
    public void AspectOfNatureShouldRemoveAspectOfTheWild()
    {
      var aspectOfTheWild = new AspectOfTheWild();
      var aspectOfNature = new AspectOfNature();
      var actor = new Actor();
      actor.Add(aspectOfTheWild)
           .Add(aspectOfNature);

      Assert.AreEqual(0, actor.Armor);
      Assert.AreEqual(0, actor.Strength);
      Assert.AreEqual(15, actor.Stamina);
    }

    [TestMethod]
    public void PowerWordFortitudeShouldIncreaseStamina()
    {
      var buff = new PowerWordFortitude();
      var actor = new Actor();
      actor.Add(buff);

      Assert.AreEqual(0, actor.Armor);
      Assert.AreEqual(0, actor.Strength);
      Assert.AreEqual(15, actor.Stamina);
    }

    [TestMethod]
    public void PowerWordFortitudeShouldStack()
    {
      var buff = new PowerWordFortitude();
      var actor = new Actor(new Stats(armor: 100));
      actor
        .Add(buff)
        .Add(buff)
        .Add(buff)
        .Add(buff);

      Assert.AreEqual(60, actor.Stamina);
      Assert.AreEqual(100, actor.Armor);
    }
  }
}