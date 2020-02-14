using MatchEntities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Kill : PlayerEvent
    {
        public long KillId { get; set; }
        public EquipmentElement PlayerPrimary { get; set; }
        public EquipmentElement PlayerSecondary { get; set; }
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
        public EquipmentElement VictimPrimary { get; set; }
        public EquipmentElement VictimSecondary { get; set; }
        public bool AssistByFlash { get; set; }
        public long? AssisterId { get; set; }
        private float AssisterPosX { get; set; }
        private float AssisterPosY { get; set; }
        private float AssisterPosZ { get; set; }
        public Vector3 AssisterPos
        {
            get
            {
                return new Vector3(AssisterPosX, AssisterPosY, AssisterPosZ);
            }

            set
            {
                AssisterPosX = value.X;
                AssisterPosY = value.Y;
                AssisterPosZ = value.Z;
            }
        }
        public KillType KillType { get; set; }
        public EquipmentElement Weapon { get; set; }
        public bool TeamKill { get; set; }
        public long? DamageId { get; set; }
        public int? PlayerZoneByTeam { get; set; }
        public int? VictimZoneByTeam { get; set; }

        [JsonIgnore]
        public virtual Damage Damage { get; set; }
        [JsonIgnore]
        public virtual PlayerMatchStats VictimMatchStats { get; set; }
        [JsonIgnore]
        public virtual PlayerRoundStats VictimRoundStats { get; set; }
    }
}
