using System;
using System.Collections.Generic;

namespace Bowling.Models
{
    public class Players {
        public struct Player
        {
            public int PlayerId { get; set; }
            public string PlayerName { get; set; }
            public int Order { get; set; }
            public bool BumperRails { get; set; }
        }
    }
}