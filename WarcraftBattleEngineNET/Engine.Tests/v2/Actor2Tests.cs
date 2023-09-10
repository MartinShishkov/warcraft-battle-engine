using Engine.Models.v2.Actors;

namespace Engine.Tests.v2
{
  [TestClass]
  public class Actor2Tests
  {
    [TestMethod]
    public void DefaultsShouldBeZeroes()
    {
      var actor = new Actor2();
      Assert.AreEqual(0, actor.Armor);
      Assert.AreEqual(0, actor.Intellect);
      Assert.AreEqual(0, actor.Strength);
      Assert.AreEqual(0, actor.Stamina);
      Assert.AreEqual(0, actor.TotalHealthPoints);
      Assert.AreEqual(0, actor.TotalManaPoints);
    }
  }
}
