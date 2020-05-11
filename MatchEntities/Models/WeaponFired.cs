using MatchEntities.Enums;
using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class WeaponFired : PlayerViewEvent,
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent
    {
        public WeaponFired()
        {
            Damage = new HashSet<Damage>();
        }

        public long WeaponFiredId { get; set; }

        private float PlayerVeloX { get; set; }
        private float PlayerVeloY { get; set; }
        private float PlayerVeloZ { get; set; }
        public Vector3 PlayerVelo
        {
            get
            {
                return new Vector3(PlayerVeloX, PlayerVeloY, PlayerVeloZ);
            }

            set
            {
                PlayerVeloX = value.X;
                PlayerVeloY = value.Y;
                PlayerVeloZ = value.Z;
            }
        }

        public EquipmentElement Weapon { get; set; }
        public float InAccuracyFromFiring { get; set; }
        public float InAccuracyFromMoving { get; set; }
        public bool IsDucking { get; set; }

        [JsonIgnore]
        public virtual ICollection<Damage> Damage { get; set; }
    }
}
