﻿using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class BotTakeOver : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public long BotTakeOverId { get; set; }
        public long PlayerId { get; set; }
        public long BotId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }

        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
    }
}
