using MatchEntities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities
{
    /// <summary>
    /// Database model for the settings which DemoAnalyzer used to analyzed a demo.
    /// </summary>
    public class AnalyzerConfigDatabaseModel
    {
        public AnalyzerQuality Quality { get; set; }
        public double FramesPerSecond { get; set; }

        public AnalyzerConfigDatabaseModel(AnalyzerQuality quality, double framesPerSecond)
        {
            Quality = quality;
            FramesPerSecond = framesPerSecond;
        }
    }
}
