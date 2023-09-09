using Engine.Models.Buffs;

namespace Engine.Models
{
  public interface IBuffModifier
  {
    Buff Modify(Buff buff);
  }
}
