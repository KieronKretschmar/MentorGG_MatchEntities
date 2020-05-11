using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities.Interfaces
{
    /// <summary>
    /// Event that took place at a particular time during a match.
    /// </summary>
    public interface IIngameEvent :
        IMatchDataEntity,
        IRoundEntity
    {
        public int Time { get; set; }
    }
}
