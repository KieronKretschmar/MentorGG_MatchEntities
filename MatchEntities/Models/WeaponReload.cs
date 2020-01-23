using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class WeaponReload : PlayerViewEvent
    {

        public long WeaponReloadId { get; set; }        
       
        public short Weapon { get; set; }
        public short AmmoBefore { get; set; }
        public short AmmoAfter { get; set; }
        public short ReserveAmmo { get; set; }
    }
}
