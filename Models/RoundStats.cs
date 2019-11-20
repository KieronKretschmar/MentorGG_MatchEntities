﻿using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class RoundStats : IMatchDataEntity
    {
        public RoundStats()
        {
            BotTakeOver = new HashSet<BotTakeOver>();
            ConnectDisconnect = new HashSet<ConnectDisconnect>();
            Damage = new HashSet<Damage>();
            Decoy = new HashSet<Decoy>();
            FireNade = new HashSet<FireNade>();
            Flash = new HashSet<Flash>();
            Flashed = new HashSet<Flashed>();
            He = new HashSet<He>();
            HostageDrop = new HashSet<HostageDrop>();
            HostagePickUp = new HashSet<HostagePickUp>();
            HostageRescue = new HashSet<HostageRescue>();
            ItemDropped = new HashSet<ItemDropped>();
            ItemPickedUp = new HashSet<ItemPickedUp>();
            ItemSaved = new HashSet<ItemSaved>();
            Kills = new HashSet<Kill>();
            PlayerPosition = new HashSet<PlayerPosition>();
            PlayerRoundStats = new HashSet<PlayerRoundStats>();
            RoundItem = new HashSet<RoundItem>();
            Smoke = new HashSet<Smoke>();
            WeaponFired = new HashSet<WeaponFired>();
            WeaponReload = new HashSet<WeaponReload>();
        }

        public long MatchId { get; set; }
        public short Round { get; set; }
        public byte WinnerTeam { get; set; }
        public bool OriginalSide { get; set; }
        public bool BombPlanted { get; set; }
        public byte? WinType { get; set; }
        public int RoundTime { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int RealEndTime { get; set; }
        public int StartTick { get; set; }
        public int EndTick { get; set; }
        public int RealEndTick { get; set; }
        public int TerrorStrategyId { get; set; }
        public int CtStrategyId { get; set; }
        public int CtPlayedValue { get; set; }
        public int TPlayedValue { get; set; }
        public int CtBuyStrat { get; set; }
        public int TBuyStrat { get; set; }

        public MatchStats MatchStats { get; set; }
        public BombDefused BombDefused { get; set; }
        public BombExplosion BombExplosion { get; set; }
        public BombPlant BombPlant { get; set; }
        public ICollection<BotTakeOver> BotTakeOver { get; set; }
        public ICollection<ConnectDisconnect> ConnectDisconnect { get; set; }
        public ICollection<Damage> Damage { get; set; }
        public ICollection<Decoy> Decoy { get; set; }
        public ICollection<FireNade> FireNade { get; set; }
        public ICollection<Flash> Flash { get; set; }
        public ICollection<Flashed> Flashed { get; set; }
        public ICollection<He> He { get; set; }
        public ICollection<HostageDrop> HostageDrop { get; set; }
        public ICollection<HostagePickUp> HostagePickUp { get; set; }
        public ICollection<HostageRescue> HostageRescue { get; set; }
        public ICollection<ItemDropped> ItemDropped { get; set; }
        public ICollection<ItemPickedUp> ItemPickedUp { get; set; }
        public ICollection<ItemSaved> ItemSaved { get; set; }
        public ICollection<Kill> Kills { get; set; }
        public ICollection<PlayerPosition> PlayerPosition { get; set; }
        public ICollection<PlayerRoundStats> PlayerRoundStats { get; set; }
        public ICollection<RoundItem> RoundItem { get; set; }
        public ICollection<Smoke> Smoke { get; set; }
        public ICollection<WeaponFired> WeaponFired { get; set; }
        public ICollection<WeaponReload> WeaponReload { get; set; }
    }
}
