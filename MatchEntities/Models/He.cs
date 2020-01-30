using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class He : Grenade,IMatchDataEntity
    {
        public He()
        {
            Damage = new HashSet<Damage>();
        }

        [JsonIgnore]
        public ICollection<Damage> Damage { get; set; }
    }
}
