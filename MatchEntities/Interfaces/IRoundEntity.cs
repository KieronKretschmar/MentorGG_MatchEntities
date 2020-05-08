using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities.Interfaces
{
    /// <summary>
    /// Entity that belongs to a certain round in a match.
    /// </summary>
    public interface IRoundEntity : IMatchDataEntity
    {
        short Round { get; set; }
    }
}
