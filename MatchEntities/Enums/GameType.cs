using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities.Enums
{
    /// <summary>
    /// Copied from DemoInfo. Keep in sync when applying changes to either of them.
    /// </summary>
    public enum GameType : byte
    {
        Bomb = 0,
        Hostage = 1,
        Vip = 3,
        Unknown = 4
    }
}
