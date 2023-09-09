using Engine.Models.Buffs;
using Engine.Models.Items;
using Engine.Models.Talents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Actors
{
  public class ActorBuilder : IActorBuilder
  {
    private readonly ItemCollection _items;
    private readonly TalentCollection _talents;
    private readonly BuffCollection _buffs;

    public ActorBuilder()
    {
      this._items = new ItemCollection();
      this._talents = new TalentCollection();
      this._buffs = new BuffCollection();
    }

    public IActorBuilder Add(Item item)
    {
      _items.Add(item);
      return this;
    }

    public IActorBuilder Add(Talent item)
    {
      _talents.Add(item);
      return this;
    }

    public IActorBuilder Add(Buff item)
    {
      _buffs.Add(item);
      return this;
    }

    public Actor Build()
    {
      return new Actor();
    }
  }
}
