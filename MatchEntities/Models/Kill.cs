﻿using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Kill : IMatchDataEntity
    {
        public Kill()
        {
            RefraggedBy = new HashSet<Refrag>();
        }

        public long MatchId { get; set; }
        public long KillId { get; set; }
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
        public short PlayerPrimary { get; set; }
        public short PlayerSecondary { get; set; }
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
        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerMatchStats VictimMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public PlayerRoundStats VictimRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
        public Refrag Refrag { get; set; }
        public ICollection<Refrag> RefraggedBy { get; set; }
    }
}
