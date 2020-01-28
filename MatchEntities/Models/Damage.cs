﻿using MatchEntities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Damage : PlayerEvent
    {
        public Damage()
        {
            Kills = new HashSet<Kill>();
        }
        public long DamageId { get; set; }
        public long VictimId { get; set; }
        private float VictimPosX { get; set; }
        private float VictimPosY { get; set; }
        private float VictimPosZ { get; set; }
        public Vector3 VictimPos
        {
            get
            {
                return new Vector3(VictimPosX, VictimPosY, VictimPosZ);
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
        public HitGroup HitGroup { get; set; }
        public EquipmentElement Weapon { get; set; }
        public bool Fatal { get; set; }
        public bool TeamAttack { get; set; }
        public long? WeaponFiredId { get; set; }
        public long? HeGrenadeId { get; set; }
        public long? FireNadeId { get; set; }
        public long? DecoyId { get; set; }
        public int? PlayerZoneByTeam { get; set; }
        public int? VictimZoneByTeam { get; set; }

        [JsonIgnore]
        public Decoy Decoy { get; set; }
        [JsonIgnore]
        public FireNade FireNade { get; set; }
        [JsonIgnore]
        public He He { get; set; }
        [JsonIgnore]
        public WeaponFired WeaponFired { get; set; }
        [JsonIgnore]
        public ICollection<Kill> Kills { get; set; }
        [JsonIgnore]
        public PlayerMatchStats VictimMatchStats { get; set; }
        [JsonIgnore]
        public PlayerRoundStats VictimRoundStats { get; set; }

    }
}
