using System;
using System.Collections.Generic;

namespace Bowling.Models 
{

    // This will contain a single game with multiple players. 
    // Methods: Can calculate who is winning in current game, end game winner, if the game is in progress or complete, and what progress of the game (what frame they're on)
    // DB: Add Player games to this Bowling Game 
    public class BowlingGame {
        public int BowlingGameId { get; set; }
        public string BowlingGameName { get; set; }
        public int CurrentFrame {get;set;}
        public int CurrentPlayer {get;set;}
        public int NextPlayer {get;set;}
        public List<SinglePlayerScore> PlayerScores {get;set;} // Instantiate these when the game starts  
    }
}