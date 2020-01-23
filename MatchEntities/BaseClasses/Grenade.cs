using System.Numerics;

namespace MatchEntities
{
    public abstract class Grenade : PlayerViewEvent
    {
        public long GrenadeId { get; set; }

        private float GrenadePosX { get; set; }
        private float GrenadePosY { get; set; }
        private float GrenadePosZ { get; set; }
        public string Trajectory { get; set; }


        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }

       
        public  Vector3 DetonationPosition => new Vector3(GrenadePosX, GrenadePosY, GrenadePosZ);
    }
}