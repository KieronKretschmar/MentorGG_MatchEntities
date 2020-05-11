using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Decoy : Grenade,
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent,
        IGrenadeThrow
    {
        public Decoy()
        {
            Damage = new HashSet<Damage>();
        }

        [JsonIgnore]
        public virtual ICollection<Damage> Damage { get; set; }
    }
}
