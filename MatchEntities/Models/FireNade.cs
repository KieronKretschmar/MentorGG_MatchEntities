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
        //TODO OPTIONAL Remove either IsMolotov or NadeType
        public byte NadeType { get; set; }
        public bool IsMolotov { get; set; }
        public ICollection<Damage> Damage { get; set; }
    }
}
