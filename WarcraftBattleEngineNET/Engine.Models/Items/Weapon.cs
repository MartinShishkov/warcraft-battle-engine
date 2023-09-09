using Engine.Models.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Items
{
  /// <summary>
  /// When making an attack, we have to keep in mind 
  /// what kind of an attack it is, because we don't want to include 
  /// weapons that we didn't use to perform that attack. If the attack happened
  /// with the main hand weapon, then we should disregard the modification
  /// from the off-hand weapon if there is one
  /// </summary>
  public class Weapon : Item, IAttackModifier
  {
    public Weapon(ItemSlot slot, Stats stats) : base(slot, stats)
    {
    }
  }
}
