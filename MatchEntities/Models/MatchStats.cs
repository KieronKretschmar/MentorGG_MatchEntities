using MatchEntities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class MatchStats : IMatchDataEntity
    {
        public MatchStats()
        {
            BombDefused = new HashSet<BombDefused>();
            BombExplosion = new HashSet<BombExplosion>();
            BombPlant = new HashSet<BombPlant>();
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
            PlayerMatchStats = new HashSet<PlayerMatchStats>();
            PlayerPosition = new HashSet<PlayerPosition>();
            PlayerRoundStats = new HashSet<PlayerRoundStats>();
            RoundItem = new HashSet<RoundItem>();
            RoundStats = new HashSet<RoundStats>();
            Smoke = new HashSet<Smoke>();
            WeaponFired = new HashSet<WeaponFired>();
            WeaponReload = new HashSet<WeaponReload>();
        }

        public long MatchId { get; set; }
        public DateTime MatchDate { get; set; } = new DateTime(2000);
        public string Map { get; set; }
        public StartingFaction WinnerTeam { get; set; }

        #region TeamMatchStats
        // team 1 is the team that starts as terrorists first
        // team 2 is CtStarter
        private short Score1 { get; set; }
        private short Score2 { get; set; }
        private short RealScore1 { get; set; }
        private short RealScore2 { get; set; }
        private short NumRoundsT1 { get; set; }
        private short NumRoundsCt1 { get; set; }
        private short NumRoundsT2 { get; set; }
        private short NumRoundsCt2 { get; set; }
        private short BombPlants1 { get; set; }
        private short BombPlants2 { get; set; }
        private short BombExplodes1 { get; set; }
        private short BombExplodes2 { get; set; }
        private short BombDefuses1 { get; set; }
        private short BombDefuses2 { get; set; }
        private int MoneyEarned1 { get; set; }
        private int MoneyEarned2 { get; set; }
        private int MoneySpent1 { get; set; }
        private int MoneySpent2 { get; set; }

        public Dictionary<StartingFaction, TeamMatchStats> TeamStats 
        { 
            get
            {
                return new Dictionary<StartingFaction, TeamMatchStats>
                {
                    {
                        StartingFaction.TerroristStarter,
                        new TeamMatchStats
                        {
                            Score = Score1,
                            RealScore = RealScore1,
                            BombDefuses = BombDefuses1,
                            BombExplodes = BombExplodes1,
                            BombPlants = BombPlants1,
                            MoneyEarned = MoneyEarned1,
                            MoneySpent = MoneySpent1,
                            NumRoundsCt = NumRoundsCt1,
                            NumRoundsT = NumRoundsT1,
                        }
                    },
                    {
                        StartingFaction.CtStarter,
                        new TeamMatchStats
                        {
                            Score = Score2,
                            RealScore = RealScore2,
                            BombDefuses = BombDefuses2,
                            BombExplodes = BombExplodes2,
                            BombPlants = BombPlants2,
                            MoneyEarned = MoneyEarned2,
                            MoneySpent = MoneySpent2,
                            NumRoundsCt = NumRoundsCt2,
                            NumRoundsT = NumRoundsT2,
                        }
                    }
                };
            } 
            set
            {
                if(value.TryGetValue(StartingFaction.TerroristStarter, out var terroristStarterTeamStats))
                {
                    Score1 = terroristStarterTeamStats.Score;
                    RealScore1 = terroristStarterTeamStats.RealScore;
                    BombDefuses1 = terroristStarterTeamStats.BombDefuses;
                    BombExplodes1 = terroristStarterTeamStats.BombExplodes;
                    BombPlants1 = terroristStarterTeamStats.BombPlants;
                    MoneyEarned1 = terroristStarterTeamStats.MoneyEarned;
                    MoneySpent1 = terroristStarterTeamStats.MoneySpent;
                    NumRoundsCt1 = terroristStarterTeamStats.NumRoundsCt;
                    NumRoundsT1 = terroristStarterTeamStats.NumRoundsT;
                }
                if (value.TryGetValue(StartingFaction.CtStarter, out var ctStarterTeamStats))
                {
                    Score2 = ctStarterTeamStats.Score;
                    RealScore2 = terroristStarterTeamStats.RealScore;
                    BombDefuses2 = ctStarterTeamStats.BombDefuses;
                    BombExplodes2 = ctStarterTeamStats.BombExplodes;
                    BombPlants2 = ctStarterTeamStats.BombPlants;
                    MoneyEarned2 = ctStarterTeamStats.MoneyEarned;
                    MoneySpent2 = ctStarterTeamStats.MoneySpent;
                    NumRoundsCt2 = ctStarterTeamStats.NumRoundsCt;
                    NumRoundsT2 = ctStarterTeamStats.NumRoundsT;
                }

                if (value.ContainsKey(StartingFaction.Spectate))
                {
                    throw new KeyNotFoundException("Tried to assign a MatchStats.TeamStats value for Spectators team, but spectators shouldn't have one such entry.");
                }
            }
        }

        #endregion
        public int? AvgRoundTime { get; set; }
        public int RoundTimer { get; set; }
        public int BombTimer { get; set; }
        public int StartMoney { get; set; }
        public short DemoTickRate { get; set; }
        public short SourceTickRate { get; set; }
        public Source Source { get; set; }
        public GameType GameType { get; set; }
        public float? AvgRank { get; set; }
        public string Event { get; set; }

        /// <summary>
        /// Owned entity
        /// </summary>
        public virtual AnalyzerConfigDatabaseModel Config { get; set; }

        [JsonIgnore]
        public virtual OverTimeStats OverTimeStats { get; set; }
        [JsonIgnore]
        public virtual ICollection<BombDefused> BombDefused { get; set; }
        [JsonIgnore]
        public virtual ICollection<BombExplosion> BombExplosion { get; set; }
        [JsonIgnore]
        public virtual ICollection<BombPlant> BombPlant { get; set; }
        [JsonIgnore]
        public virtual ICollection<BotTakeOver> BotTakeOver { get; set; }
        [JsonIgnore]
        public virtual ICollection<ConnectDisconnect> ConnectDisconnect { get; set; }
        [JsonIgnore]
        public virtual ICollection<Damage> Damage { get; set; }
        [JsonIgnore]
        public virtual ICollection<Decoy> Decoy { get; set; }
        [JsonIgnore]
        public virtual ICollection<FireNade> FireNade { get; set; }
        [JsonIgnore]
        public virtual ICollection<Flash> Flash { get; set; }
        [JsonIgnore]
        public virtual ICollection<Flashed> Flashed { get; set; }
        [JsonIgnore]
        public virtual ICollection<He> He { get; set; }
        [JsonIgnore]
        public virtual ICollection<HostageDrop> HostageDrop { get; set; }
        [JsonIgnore]
        public virtual ICollection<HostagePickUp> HostagePickUp { get; set; }
        [JsonIgnore]
        public virtual ICollection<HostageRescue> HostageRescue { get; set; }
        [JsonIgnore]
        public virtual ICollection<ItemDropped> ItemDropped { get; set; }
        [JsonIgnore]
        public virtual ICollection<ItemPickedUp> ItemPickedUp { get; set; }
        [JsonIgnore]
        public virtual ICollection<ItemSaved> ItemSaved { get; set; }
        [JsonIgnore]
        public virtual ICollection<Kill> Kills { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlayerMatchStats> PlayerMatchStats { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlayerPosition> PlayerPosition { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlayerRoundStats> PlayerRoundStats { get; set; }
        [JsonIgnore]
        public virtual ICollection<RoundItem> RoundItem { get; set; }
        [JsonIgnore]
        public virtual ICollection<RoundStats> RoundStats { get; set; }
        [JsonIgnore]
        public virtual ICollection<Smoke> Smoke { get; set; }
        [JsonIgnore]
        public virtual ICollection<WeaponFired> WeaponFired { get; set; }
        [JsonIgnore]
        public virtual ICollection<WeaponReload> WeaponReload { get; set; }
    }

    public class TeamMatchStats
    {
        public short Score { get; set; }
        public short RealScore { get; set; }
        public short NumRoundsT { get; set; }
        public short NumRoundsCt { get; set; }
        public short BombPlants { get; set; }
        public short BombExplodes { get; set; }
        public short BombDefuses { get; set; }
        public int MoneyEarned { get; set; }
        public int MoneySpent { get; set; }
    }
}
