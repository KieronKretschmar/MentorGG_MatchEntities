using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MatchEntities.Interfaces
{
    /// <summary>
    /// Event based on a particular player's action.
    /// </summary>
    public interface IPlayerEvent :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent
    {
        public long PlayerId { get; set; }
        public bool IsCt { get; set; }
        public Vector3 PlayerPos { get; set; }
    }
}
