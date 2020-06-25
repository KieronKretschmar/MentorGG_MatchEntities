using MatchEntities.Enums;
using MatchEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class PlayerPosition : PlayerViewEvent,
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent
    {
        public EquipmentElement Weapon { get; set; }
    }
}
