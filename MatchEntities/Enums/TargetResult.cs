using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities.Enums
{
    public enum TargetResult : byte
    {
        Default = 0, // This is the default value of unrated smokes
        Inside = 10, // Inside Target, yet not gapfree. Does have some effect.
        Miss = 20, // Not in Target. This is bad.
        TargetWithoutLineUp = 30, //Hit a target without using a known lineup
        NoTarget = 40, //Has no lineup and didnt hit a target, but was analyzed
    }
}
