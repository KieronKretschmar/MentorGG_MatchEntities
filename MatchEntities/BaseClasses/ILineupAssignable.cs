using MatchEntities.Enums;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MatchEntities
{
    public interface ILineupAssignable
    {
        public int LineUp { get; set; }
        public int Target { get; set; }
        public TargetResult Result { get; set; }

        public Vector3 DetonationPosition { get; set; }
    }
}
