﻿using System;
using System.Collections.Generic;

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
        public double PlayerPosX { get; set; }
        public double PlayerPosY { get; set; }
        public double PlayerPosZ { get; set; }
        public short PlayerPrimary { get; set; }
        public short PlayerSecondary { get; set; }
        public bool IsCt { get; set; }
        public long VictimId { get; set; }
        public double VictimPosX { get; set; }
        public double VictimPosY { get; set; }
        public double VictimPosZ { get; set; }
        public short VictimPrimary { get; set; }
        public short VictimSecondary { get; set; }
        public bool AssistByFlash { get; set; }
        public long? AssisterId { get; set; }
        public double? AssisterPosX { get; set; }
        public double? AssisterPosY { get; set; }
        public double? AssisterPosZ { get; set; }
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