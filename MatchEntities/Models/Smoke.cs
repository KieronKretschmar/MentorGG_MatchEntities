using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Smoke : Grenade, IMatchDataEntity
    {
        public int Category { get; set; }
        public int Target { get; set; }
        public TargetResult Result { get; set; }
    }
}
