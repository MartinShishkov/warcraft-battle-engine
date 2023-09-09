using Engine.Models.Actors;
using Engine.Models.Items.Implementations;

namespace Engine.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void BasicShield_ShouldIncreaseArmor()
    {
      var actor = new Actor();
      actor.Add(new BasicShield());
      Assert.AreEqual(100, actor.Armor);
    }

    [TestMethod]
    public void BasicShield_ShouldReplaceAlreadyEquippedItem()
    {
      var actor = new Actor();
      actor
        .Add(new BasicShield())
        .Add(new BasicShield(level: 2));
      Assert.AreEqual(200, actor.Armor);
    }

    [TestMethod]
    public void EquipMultipleItems()
    {
      var actor = new Actor();
      actor
        .Add(new BasicShield())
        .Add(new BasicSword());
      Assert.AreEqual(100, actor.Armor);
      Assert.AreEqual(10, actor.Strength);
    }
  }
}