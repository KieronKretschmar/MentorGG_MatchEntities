using MatchEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatchEntitiesTest
{
    public static class TestData
    {
        public static MatchDataSet GetTestDataSet()
        {

            //var bomb2 = kills.Select(x => x as IMatchDataEntity).ToList();
            var dataSet = new MatchDataSet();
            dataSet.MatchStats = new MatchStats();
            dataSet.KillsList = new List<Kill>
            {
                new Kill{MatchId = 1, PlayerId = 200, }
            }; 

            return dataSet;
        }
    }
}
