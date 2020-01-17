using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class Decoy : IMatchDataEntity
    {
        public Decoy()
        {
            Damage = new HashSet<Damage>();
        }

        public long MatchId { get; set; }
        public long GrenadeId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }
        public long PlayerId { get; set; }
        public float PlayerPosX { get; set; }
        public float PlayerPosY { get; set; }
        public float PlayerPosZ { get; set; }
        public float PlayerViewX { get; set; }
        public float PlayerViewY { get; set; }
        public bool IsCt { get; set; }
        public float GrenadePosX { get; set; }
        public float GrenadePosY { get; set; }
        public float GrenadePosZ { get; set; }
        public string Trajectory { get; set; }

        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
        public ICollection<Damage> Damage { get; set; }
    }
}
