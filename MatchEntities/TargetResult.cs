using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities
{
    public enum TargetResult : byte
    {
        Default = 0, // This is the default value of unrated smokes
        Inside = 10, // Inside Target, yet not gapfree. Does have some effect.
        Miss = 20, // Not in Target. This is bad.
        TargetWithoutCategory = 30,
    }
}
