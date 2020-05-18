using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class He : Grenade,
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent,
        IGrenadeEvent
    {
        public He()
        {
            Damage = new HashSet<Damage>();
        }

        [JsonIgnore]
        public virtual ICollection<Damage> Damage { get; set; }
    }
}
