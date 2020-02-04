using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities.Enums
{
    /// <summary>
    /// Identifies a team throughout a game by the faction on which it started.
    /// 
    /// Copied from DemoInfo's Team enum. Keep in sync when applying changes to either of them.
    /// </summary>
    public enum StartingFaction : byte
    {
        Spectate = 1,
        TerroristStarter = 2,
        CtStarter = 3,
    }
}
