using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities.Enums
{
	/// <summary>
	/// Copied from DemoInfo. Keep in sync when applying changes to either of them.
	/// </summary>
	public enum KillType : byte
    {
        BodyShot = 0,
        CoverBodyShot = 1,
        HeadShot = 2,
        CoverHeadShot = 3,
        He = 4,
        Molotov = 5,
        Flash = 6,
        Smoke = 7,
        Knife = 8,
        Zeus = 9,
        Unknown = 10,
        World = 11
    }
}
