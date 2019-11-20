using MatchEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MatchEntitiesTest
{
    [TestClass]
    public class MatchIdAssignmentTest
    {
        [TestMethod]
        public void AssignMatchIdsTest()
        {
            var matchId = 23;
            var dataSet = TestData.GetTestDataSet();
            dataSet.AssignMatchId(matchId);
            var allMatchIdsSet = dataSet.Tables().All(x => x.All(y => y.MatchId == matchId));
            Assert.IsTrue(allMatchIdsSet);
        }
    }
}
