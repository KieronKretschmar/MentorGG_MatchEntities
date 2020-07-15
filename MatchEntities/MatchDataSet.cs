using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MatchEntities
{
    public class MatchDataSet
    {
        #region Tables
        public MatchStats MatchStats = new MatchStats();

        public OverTimeStats OverTimeStats;

        public List<PlayerMatchStats> PlayerMatchStatsList = new List<PlayerMatchStats>();

        public List<RoundStats> RoundStatsList = new List<RoundStats>();

        public List<PlayerRoundStats> PlayerRoundStatsList = new List<PlayerRoundStats>();

        public List<DroppedBombPosition> DroppedBombPositionList = new List<DroppedBombPosition>();

        public List<BombPlant> BombPlantList = new List<BombPlant>();

        public List<BombDefused> BombDefusedList = new List<BombDefused>();

        public List<BombExplosion> BombExplosionList = new List<BombExplosion>();

        public List<BotTakeOver> BotTakeOverList = new List<BotTakeOver>();

        public List<ConnectDisconnect> ConnectDisconnectList = new List<ConnectDisconnect>();

        public List<HostageDrop> HostageDropList = new List<HostageDrop>();

        public List<HostagePickUp> HostagePickUpList = new List<HostagePickUp>();

        public List<HostageRescue> HostageRescueList = new List<HostageRescue>();

        public List<ItemDropped> ItemDroppedList = new List<ItemDropped>();

        public List<ItemPickedUp> ItemPickedUpList = new List<ItemPickedUp>();

        public List<ItemSaved> ItemSavedList = new List<ItemSaved>();

        public List<RoundItem> RoundItemList = new List<RoundItem>();

        public List<PlayerPosition> PlayerPositionList = new List<PlayerPosition>();

        public List<PlayerJump> PlayerJumpList = new List<PlayerJump>();

        public List<Decoy> DecoyList = new List<Decoy>();

        public List<FireNade> FireNadeList = new List<FireNade>();

        public List<Flash> FlashList = new List<Flash>();

        public List<Flashed> FlashedList = new List<Flashed>();

        public List<He> HeList = new List<He>();

        public List<Smoke> SmokeList = new List<Smoke>();

        public List<Damage> DamageList = new List<Damage>();

        public List<Kill> KillList = new List<Kill>();

        public List<WeaponReload> WeaponReloadList = new List<WeaponReload>();

        public List<WeaponFired> WeaponFiredList = new List<WeaponFired>();
        #endregion

        public List<IEnumerable<IMatchDataEntity>> Tables()
        {
            var tablesList = new List<IEnumerable<IMatchDataEntity>>()
            {
                new List<IMatchDataEntity>() { MatchStats as IMatchDataEntity },
                new List<IMatchDataEntity>() { OverTimeStats as IMatchDataEntity },
                PlayerMatchStatsList.Select(x=>x as IMatchDataEntity),
                RoundStatsList.Select(x=>x as IMatchDataEntity),
                PlayerRoundStatsList.Select(x=>x as IMatchDataEntity),
                DroppedBombPositionList.Select(x=>x as IMatchDataEntity),
                BombPlantList.Select(x=>x as IMatchDataEntity),
                BombDefusedList.Select(x=>x as IMatchDataEntity),
                BombExplosionList.Select(x=>x as IMatchDataEntity),
                BotTakeOverList.Select(x=>x as IMatchDataEntity),
                ConnectDisconnectList.Select(x=>x as IMatchDataEntity),
                HostageDropList.Select(x=>x as IMatchDataEntity),
                HostagePickUpList.Select(x=>x as IMatchDataEntity),
                HostageRescueList.Select(x=>x as IMatchDataEntity),
                ItemDroppedList.Select(x=>x as IMatchDataEntity),
                ItemPickedUpList.Select(x=>x as IMatchDataEntity),
                ItemSavedList.Select(x=>x as IMatchDataEntity),
                RoundItemList.Select(x=>x as IMatchDataEntity),
                PlayerPositionList.Select(x=>x as IMatchDataEntity),
                PlayerJumpList.Select(x=>x as IMatchDataEntity),
                DecoyList.Select(x=>x as IMatchDataEntity),
                FireNadeList.Select(x=>x as IMatchDataEntity),
                HeList.Select(x=>x as IMatchDataEntity),
                SmokeList.Select(x=>x as IMatchDataEntity),
                WeaponReloadList.Select(x=>x as IMatchDataEntity),
                WeaponFiredList.Select(x=>x as IMatchDataEntity),
                DamageList.Select(x=>x as IMatchDataEntity), // must be inserted after weaponFiredList due to FK_Damage_WeaponFired
                KillList.Select(x=>x as IMatchDataEntity), // must be inserted after damageList due to FK_Kills_Damage
                FlashList.Select(x=>x as IMatchDataEntity),
                FlashedList.Select(x=>x as IMatchDataEntity),
            };
            return tablesList;
        }

        /// <summary>
        /// Serializes object to JSON using the correct configuration, such that it can be deserialized without loss of information.
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(
                this,
                new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    NullValueHandling = NullValueHandling.Ignore,
                    TypeNameHandling = TypeNameHandling.Auto,
                    Formatting = Formatting.Indented
                }
            );
        }

        public static MatchDataSet FromJson(string json)
        {
            MatchDataSet dataSet = JsonConvert.DeserializeObject<MatchDataSet>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                
                // this setting is required so that the setter for MatchStats.TeamStats is called on deserialization
                ObjectCreationHandling = ObjectCreationHandling.Replace,
            });

            return dataSet;
        }

        public long MatchId => this.MatchStats.MatchId;

        public void AssignMatchId(long matchId)
        {
            foreach (var table in Tables())
            {
                foreach (var entry in table)
                {
                    entry.MatchId = matchId;
                }
            }
        }

        /// <summary>
        /// Checks whether MatchDataSet contents are equal.
        /// This method is not made to be performant.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool ContentEquals(MatchDataSet other)
        {
            if (other == null)
            {
                return false;
            }

            // Make sure both MatchDataSets have populated the same tables
            var thisPopulatedTableTypes = this.Tables().Where(x => x.Any()).Select(x => x.First().GetType()).ToList();
            var otherPopulatedTableTypes = other.Tables().Where(x => x.Any()).Select(x => x.First().GetType()).ToList();
            //var debug = thisPopulatedTableTypes.OrderBy(t => t).Zip(otherPopulatedTableTypes.OrderBy(t => t.Name), (t, o) => new { thisItem = t, otherItem = o });
            var populatedTableTypesAreEqual = Enumerable.SequenceEqual(thisPopulatedTableTypes.OrderBy(t => t.Name), otherPopulatedTableTypes.OrderBy(t => t.Name));
            if (!populatedTableTypesAreEqual)
            {
                return false;
            }

            // Iterate through each populated table and check whether all items in it are equal
            foreach (var tableType in thisPopulatedTableTypes)
            {
                var thisTableEntries = this.Tables().Single(x => x.FirstOrDefault()?.GetType() == tableType);
                var otherTableEntries = other.Tables().Single(x => x.FirstOrDefault()?.GetType() == tableType);
                foreach (var item in thisTableEntries.Zip(otherTableEntries, (t, o) => new { thisItem = t, otherItem = o }))
                {
                    // Check item equality using json serialization
                    var thisJson = JsonConvert.SerializeObject(item.thisItem);
                    var otherJson = JsonConvert.SerializeObject(item.otherItem);
                    if (thisJson != otherJson)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
