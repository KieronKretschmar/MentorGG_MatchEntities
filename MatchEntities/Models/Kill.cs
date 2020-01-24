using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Kill : PlayerEvent
    {
        public Kill()
        {
            RefraggedBy = new HashSet<Refrag>();
        }
        public long Id;
        public short PlayerPrimary { get; set; }
        public short PlayerSecondary { get; set; }
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
        public PlayerRoundStats VictimRoundStats { get; set; }
        public short VictimPrimary { get; set; }
        public short VictimSecondary { get; set; }
        public bool AssistByFlash { get; set; }
        public long? AssisterId { get; set; }
        private float AssisterPosX { get; set; }
        private float AssisterPosY { get; set; }
        private float AssisterPosZ { get; set; }
        private Vector3 _assisterPos;
        public Vector3 AssisterPos
        {
            get
            {
                if (_assisterPos == null)
                    _assisterPos = new Vector3(AssisterPosX, AssisterPosY, AssisterPosZ);

                return _assisterPos;
            }

            set
            {
                AssisterPosX = value.X;
                AssisterPosY = value.Y;
                AssisterPosZ = value.Z;
            }
        }
        public byte KillType { get; set; }
        public short Weapon { get; set; }
        public bool TeamKill { get; set; }
        public long? DamageId { get; set; }
        public int? PlayerZoneByTeam { get; set; }
        public int? VictimZoneByTeam { get; set; }

        public Damage Damage { get; set; }
        public Refrag Refrag { get; set; }
        public ICollection<Refrag> RefraggedBy { get; set; }
    }
}
