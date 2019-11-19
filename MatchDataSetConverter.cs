using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchDBI
{

    public static class MatchDataSetConverter
    {
        public static MatchDataSet FromJson(string version, string json)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serializes object to JSON using the correct configuration, such that it can be deserialized without loss of information.
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public static string ToJson(MatchDataSet dataSet)
        {
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);
                JsonWriter jsonWriter = new JsonTextWriter(sw);

                JsonSerializer serializer = new JsonSerializer();
                serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;
                serializer.TypeNameHandling = TypeNameHandling.Auto;
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(jsonWriter, dataSet);

                var json = sw.ToString();
                return json;
            
        }

    }
}
