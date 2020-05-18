using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MatchEntities.Interfaces
{
    /// <summary>
    /// Grenade thrown by a player.
    /// </summary>
    public interface IGrenadeEvent :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent
    {
        public string Trajectory { get; set; }
        public Vector3 DetonationPos { get; set; }
    }
}
