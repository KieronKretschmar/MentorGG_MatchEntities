using MatchEntities.Enums;
using MatchEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class WeaponReload : PlayerViewEvent,
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent
    {

        public long WeaponReloadId { get; set; }        
       
        public EquipmentElement Weapon { get; set; }
        public short AmmoBefore { get; set; }
        public short AmmoAfter { get; set; }
        public short ReserveAmmo { get; set; }
    }
}
