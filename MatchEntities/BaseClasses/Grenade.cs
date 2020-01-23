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
        public int DetonationZoneByTeam { get; set; }

       
        public  Vector3 DetonationPosition => new Vector3(GrenadePosX, GrenadePosY, GrenadePosZ);
    }
}