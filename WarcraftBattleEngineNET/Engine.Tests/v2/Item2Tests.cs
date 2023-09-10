using Engine.Models.v2.Actors;
using Engine.Models.v2.Items.Weapons.Implementations;

namespace Engine.Tests.v2
{
  [TestClass]
  public class Item2Tests
  {
    [TestMethod]
    public void BasicShield_ShouldIncreaseArmor()
    {
      var actor = new Actor2();
      actor.Add(new BasicShield2());
      Assert.AreEqual(100, actor.Armor);
    }

    [TestMethod]
    public void BasicShield_ShouldReplaceAlreadyEquippedItem()
    {
      var actor = new Actor2();
      actor
        .Add(new BasicShield2())
        .Add(new BasicShield2());
      Assert.AreEqual(100, actor.Armor);
    }

    //[TestMethod]
    //public void EquipMultipleItems()
    //{
    //  var actor = new Actor();
    //  actor
    //    .Add(new BasicShield())
    //    .Add(new BasicSword());
    //  Assert.AreEqual(100, actor.Armor);
    //  Assert.AreEqual(10, actor.Strength);
    //}
  }
}