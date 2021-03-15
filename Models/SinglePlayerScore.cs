using System;
using System.Collections.Generic;

namespace Bowling.Models
{

    // This will contain a single player's game progress
    // Methods: Return their score so far, tell you their progress, show their score history
    // DB: Add Frames to this Single Player Score until Frames.Length == 10. Update GameTotal when new Frame is added.
    public class SinglePlayerScore { 
        public int PlayerId {get;set;}
        public List<Frame> Frames = new List<Frame>(); // There will be 10 of these, order by FrameNumber
        public int GameTotal {get;set;}
    }

}