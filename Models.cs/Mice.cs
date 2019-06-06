using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

    public class Mice : ILiveOntheGround {
        
        // ILiveOntheGround
        public string AboveGround { get; set; }
        public void WalkWalkWalk() {
            Console.WriteLine("Doin' a walkabout.");
        } 

        public void HeckRun() {
            Console.WriteLine("Heckheckheckheckhe-");
        }
    }

}