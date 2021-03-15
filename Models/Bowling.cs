using System;
using System.Collections.Generic;

namespace Bowling.Models
{

    public class Bowling {
        
        public List<BowlingGame> BowlingGames = new List<BowlingGame>();
    }
    // RULES: 

    // One game of bowling consists of 10 frames

    // If all ten pins are knocked on Turn #1, it is a STRIKE denoted as "X"

    // If all ten pins are knocked down in both Turns (Turn #1 + Turn #2 == 10), it is a SPARE denoted by "/"

    // If after two shots, (Turn #1 + Turn #2 < 10), it is called an OPEN FRAME. These are taken at face value 0

    // How to score a strike: If you score 10, the next two turns will be added to this to determine your strike score. (Turn #1 == 10, Turn #2 == 10, Turn #3 == 4, Score = 24)

    // If you score a strike, there will technically be three turns counted in one frame. Min score is 10, max is 30

    // Spare is worth 10, plus value of next roll. Technically three turns in one frame. Min score is 10, max is 20

    // Open frame is up to 10. Min score = 0, max is 10



}