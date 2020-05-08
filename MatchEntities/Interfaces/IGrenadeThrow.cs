using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MatchEntities.Interfaces
{
    /// <summary>
    /// Grenade thrown by a player.
    /// </summary>
    public interface IGrenadeThrow :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent
    {
        public Vector3 DetonationPos { get; set; }
    }
}
