using MatchEntities.Enums;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MatchEntities.Interfaces
{
    public interface ILineupAssignable :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent,
        IGrenadeEvent
    {
        public int LineUp { get; set; }
        public int Target { get; set; }
        public TargetResult Result { get; set; }
    }
}
