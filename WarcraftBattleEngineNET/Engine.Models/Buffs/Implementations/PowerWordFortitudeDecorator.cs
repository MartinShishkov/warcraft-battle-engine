using Engine.Models.Actors;
using Engine.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Buffs.Implementations
{
  public class PowerWordFortitudeDecorator : Buff
  {
    private readonly PowerWordFortitude _buff;
    private readonly int _level;

    public PowerWordFortitudeDecorator(PowerWordFortitude buff, int level = 1) : base($"POWER_WORD_FORTITUDE_{level}")
    {
      this._level = Math.Min(level, 3);
      this._buff = buff;
    }

    public override Stats Modify(Stats stats)
    {
      var bonus = Percentage.From(_level, stats.Intellect);
      var fromBuff = _buff.Modify(stats);
      var fromDecorator = fromBuff.Merge(new Stats(stamina: bonus));
      return fromDecorator;
    }

    public override BuffCollection On(BuffCollection buffs)
    {
      return _buff.On(buffs);

      //var copy = buffs.Clone();
      //var existing = copy.Get(Identifier);

      //if (existing != null)
      //{
      //  copy.Remove(Identifier);
      //}

      //copy.Add(this);

      //return copy;
    }
  }
}
