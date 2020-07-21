using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities.Enums
{
    /// <summary>
    /// Copied from DemoInfo. Keep in sync when applying changes to either of them.
    public enum WinType
    {
        Elimination = 0,
        Time = 1,
        Explosion = 2,
        Defuse = 3,
        HostageRescued = 4,
        Surrender = 5,
        Unknown = 6
    }
}
