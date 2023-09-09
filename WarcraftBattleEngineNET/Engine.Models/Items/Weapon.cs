using Engine.Models.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Items
{
  public class Weapon : Item, IAttackModifier
  {
    public Weapon(ItemSlot slot, Stats stats) : base(slot, stats)
    {
    }
  }
}
