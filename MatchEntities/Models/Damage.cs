﻿using System;
using System.Collections.Generic;
using System.Numerics;

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
        private float PlayerPosX { get; set; }
        private float PlayerPosY { get; set; }
        private float PlayerPosZ { get; set; }
        private Vector3 _playerPos;
        public Vector3 PlayerPos
        {
            get
            {
                if (_playerPos == null)
                    _playerPos = new Vector3(PlayerPosX, PlayerPosY, PlayerPosZ);

                return _playerPos;
            }

            set
            {
                PlayerPosX = value.X;
                PlayerPosY = value.Y;
                PlayerPosZ = value.Z;
            }
        }
        public bool IsCt { get; set; }
        public long VictimId { get; set; }
        private float VictimPosX { get; set; }
        private float VictimPosY { get; set; }
        private float VictimPosZ { get; set; }
        private Vector3 _victimPos;
        public Vector3 VictimPos
        {
            get
            {
                if (_victimPos == null)
                    _victimPos = new Vector3(VictimPosX, VictimPosY, VictimPosZ);

                return _victimPos;
            }

            set
            {
                VictimPosX = value.X;
                VictimPosY = value.Y;
                VictimPosZ = value.Z;
            }
        }
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
