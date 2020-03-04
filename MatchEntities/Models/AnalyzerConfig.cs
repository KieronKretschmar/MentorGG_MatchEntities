using MatchEntities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities
{
    public class AnalyzerConfig
    {
        public AnalyzerQuality Quality { get; set; }
        public double FramesPerSecond { get; set; }

        public AnalyzerConfig(AnalyzerQuality quality, double framesPerSecond)
        {
            Quality = quality;
            FramesPerSecond = framesPerSecond;
        }
    }
}
