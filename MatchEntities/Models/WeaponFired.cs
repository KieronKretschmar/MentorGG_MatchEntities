using MatchEntities.Enums;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class WeaponFired : PlayerViewEvent
    {
        public WeaponFired()
        {
            Damage = new HashSet<Damage>();
        }

        public long WeaponFiredId { get; set; }

        private float PlayerVeloX { get; set; }
        private float PlayerVeloY { get; set; }
        private float PlayerVeloZ { get; set; }
        private Vector3 _playerVelo;
        public Vector3 PlayerVelo
        {
            get
            {
                if (_playerVelo == null)
                    _playerVelo = new Vector3(PlayerVeloX, PlayerVeloY, PlayerVeloZ);

                return _playerVelo;
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

        public ICollection<Damage> Damage { get; set; }
    }
}
