using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MatchEntities.Interfaces
{
    /// <summary>
    /// Event that includes a player who is victim.
    /// </summary>
    public interface IVictimEvent :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent
    {
        long VictimId { get; set; }
        public Vector3 VictimPos { get; set; }
    }
}
