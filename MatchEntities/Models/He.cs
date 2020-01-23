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
        public int DetonationZoneByTeam { get; set; }
        public ICollection<Damage> Damage { get; set; }
    }
}
