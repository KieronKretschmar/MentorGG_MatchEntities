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
        public List<List<IMatchDataEntity>> Tables { get; set; } = new List<List<IMatchDataEntity>>();


        /// <summary>
        /// Serializes object to JSON using the correct configuration.
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            JsonWriter jsonWriter = new JsonTextWriter(sw);

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.TypeNameHandling = TypeNameHandling.Auto;
            serializer.Formatting = Formatting.Indented;
            serializer.Serialize(jsonWriter, this);

            var json = sw.ToString();

            JsonConvert.SerializeObject(this);

            return json;
        }

        public void AssignMatchId(long matchId)
        {
            foreach (var table in Tables)
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
            var thisPopulatedTableTypes = this.Tables.Where(x => x.Any()).Select(x => x.First().GetType()).ToList();
            var otherPopulatedTableTypes = other.Tables.Where(x => x.Any()).Select(x => x.First().GetType()).ToList();
            var populatedTableTypesAreEqual = Enumerable.SequenceEqual(thisPopulatedTableTypes.OrderBy(t => t), otherPopulatedTableTypes.OrderBy(t => t));
            if (!populatedTableTypesAreEqual)
            {
                return false;
            }

            // Iterate through each populated table and check whether all items in it are equal
            foreach (var tableType in thisPopulatedTableTypes)
            {
                var thisTableEntries = this.Tables.Single(x => x.First().GetType() == tableType);
                var otherTableEntries = other.Tables.Single(x => x.First().GetType() == tableType);
                foreach (var item in thisTableEntries.Zip(otherTableEntries, (t, o) => new { thisItem = t, otherItem = o }))
                {
                    // Check item equality using json serialization
                    var thisJson = JsonConvert.SerializeObject(item.thisItem);
                    var otherJson = JsonConvert.SerializeObject(item.otherItem);
                    if(thisJson != otherJson)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
