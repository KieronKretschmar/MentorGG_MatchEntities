using MatchEntities.Enums;
using MatchEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Smoke : Grenade, IMatchDataEntity, ILineupAssignable
    {
        public int LineUp { get; set; }
        public int Target { get; set; }
        public TargetResult Result { get; set; }
    }
}
