using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class Damage : IMatchDataEntity
    {
        public Damage()
        {
            Kills = new HashSet<Kill>();
        }

        public long MatchId { get; set; }
        public long DamageId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }
        public long PlayerId { get; set; }
        public float PlayerPosX { get; set; }
        public float PlayerPosY { get; set; }
        public float PlayerPosZ { get; set; }
        public bool IsCt { get; set; }
        public long VictimId { get; set; }
        public float VictimPosX { get; set; }
        public float VictimPosY { get; set; }
        public float VictimPosZ { get; set; }
        public int AmountHealth { get; set; }
        public int AmountHealthPotential { get; set; }
        public int AmountArmor { get; set; }
        public byte HitGroup { get; set; }
        public short Weapon { get; set; }
        public bool Fatal { get; set; }
        public bool TeamAttack { get; set; }
        public long? WeaponFiredId { get; set; }
        public long? HeGrenadeId { get; set; }
        public long? FireNadeId { get; set; }
        public long? DecoyId { get; set; }
        public int? PlayerZoneByTeam { get; set; }
        public int? VictimZoneByTeam { get; set; }

        public Decoy Decoy { get; set; }
        public FireNade FireNade { get; set; }
        public He He { get; set; }
        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerMatchStats VictimMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public PlayerRoundStats VictimRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
        public WeaponFired WeaponFired { get; set; }
        public ICollection<Kill> Kills { get; set; }
    }
}
