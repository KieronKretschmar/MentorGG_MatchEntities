using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class WeaponFired : IMatchDataEntity
    {
        public WeaponFired()
        {
            Damage = new HashSet<Damage>();
        }

        public long MatchId { get; set; }
        public long WeaponFiredId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }
        public long PlayerId { get; set; }
        public float PlayerPosX { get; set; }
        public float PlayerPosY { get; set; }
        public float PlayerPosZ { get; set; }
        public float PlayerViewX { get; set; }
        public float PlayerViewY { get; set; }
        public float PlayerVeloX { get; set; }
        public float PlayerVeloY { get; set; }
        public float PlayerVeloZ { get; set; }
        public bool IsCt { get; set; }
        public short Weapon { get; set; }
        public float InAccuracyFromFiring { get; set; }
        public float InAccuracyFromMoving { get; set; }
        public short PlayerState { get; set; }

        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
        public ICollection<Damage> Damage { get; set; }
    }
}
