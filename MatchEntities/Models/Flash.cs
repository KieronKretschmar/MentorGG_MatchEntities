using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Flash : Grenade, IMatchDataEntity
    {
        public Flash()
        {
            Flashed = new HashSet<Flashed>();
        }

        [JsonIgnore]
        public virtual ICollection<Flashed> Flashed { get; set; }
    }
}
