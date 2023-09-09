using Engine.Models.Actors;

namespace Engine.Tests
{
  [TestClass]
  public class ActorTests
  {
    [TestMethod]
    public void DefaultsShouldBeZeroes()
    {
      var actor = new Actor();
      Assert.AreEqual(0, actor.Armor);
      Assert.AreEqual(0, actor.Intellect);
      Assert.AreEqual(0, actor.Strength);
      Assert.AreEqual(0, actor.Stamina);
      Assert.AreEqual(0, actor.TotalHealthPoints);
      Assert.AreEqual(0, actor.TotalManaPoints);
    }
  }
}