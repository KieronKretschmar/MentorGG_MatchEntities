using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class WeaponReload : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public long WeaponReloadId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }
        public long PlayerId { get; set; }
        public double PlayerPosX { get; set; }
        public double PlayerPosY { get; set; }
        public double PlayerPosZ { get; set; }
        public double PlayerViewX { get; set; }
        public double PlayerViewY { get; set; }
        public bool IsCt { get; set; }
        public short Weapon { get; set; }
        public short AmmoBefore { get; set; }
        public short AmmoAfter { get; set; }
        public short ReserveAmmo { get; set; }

        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
    }
}
