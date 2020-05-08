using MatchEntities.Interfaces;
using System.Numerics;

namespace MatchEntities
{
    public abstract class Grenade : PlayerViewEvent
    {
        public long GrenadeId { get; set; }

        private float DetonationPosX { get; set; }
        private float DetonationPosY { get; set; }
        private float DetonationPosZ { get; set; }
        public string Trajectory { get; set; }
        public int DetonationZoneByTeam { get; set; }


        public Vector3 DetonationPos
        {
            get
            {
                return new Vector3(DetonationPosX, DetonationPosY, DetonationPosZ);
            }
            set
            {
                DetonationPosX = value.X;
                DetonationPosY = value.Y;
                DetonationPosZ = value.Z;
            }
        }
    }
}