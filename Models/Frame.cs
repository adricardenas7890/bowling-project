using System;
using System.Collections.Generic;

namespace Bowling.Models
{
    // This will contain a single frame, with a list of three pin objects. 
    // Methods: Calculate Results, Calculate Frame Score, Calculate Running Total
    public class Frame {
        public int FrameNumber {get; set; }
        public string Result { get; set; }
        public int FrameScore {get;set;}
        public int RunningTotal {get;set;}
        public List<Pins> Pins = new List<Pins>();    // There will be three of these   
    }  
}