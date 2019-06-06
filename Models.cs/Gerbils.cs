using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

    public class Gerbils : ILiveOntheGround, IWalkies {
        
        // ILiveOntheGround

        public string AboveGround { get; set; }

        // IWalkies

        public void WalkWalkWalk() {
            Console.WriteLine("Doin' a walkabout.");
        } 

        public void HeckRun() {
            Console.WriteLine("Heckheckheckheckhe-");
        }
    }

}