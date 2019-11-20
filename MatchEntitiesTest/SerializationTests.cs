using MatchEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MatchEntitiesTest
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void LosslessSerialization()
        {
            var preSerializationObj = TestData.GetTestDataSet();
            var preSerializationJson = MatchDataSetConverter.ToJson(preSerializationObj);
            var postSerializationObj = MatchDataSetConverter.FromJson(preSerializationJson);
            var postSerializationJson = MatchDataSetConverter.ToJson(postSerializationObj);

            // Check whether the dataset is still the same after serializing and deserializing, using a custom Equality comparison
            Assert.IsTrue(preSerializationObj.ContentEquals(postSerializationObj));

            // Check whether they both serialize to the exact same json
            Assert.AreEqual(preSerializationJson, postSerializationJson);
        }
    }
}
