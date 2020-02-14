using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class FireNade : Grenade, IMatchDataEntity
    {
        public FireNade()
        {
            Damage = new HashSet<Damage>();
        }

        /// <summary>
        /// True for molotovs, false for incendiary grenades.
        /// </summary>
        public bool IsMolotov { get; set; }

        [JsonIgnore]
        public virtual ICollection<Damage> Damage { get; set; }
    }
}
