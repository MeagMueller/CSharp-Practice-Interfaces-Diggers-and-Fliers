using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

    public class Terrapins : ILiveOntheGround, ISwim {

        // ILiveOntheGround
        public string AboveGround { get; set; }
        public void WalkWalkWalk() {
            Console.WriteLine("Doin' a walkabout.");
        } 

        public void HeckRun() {
            Console.WriteLine("Heckheckheckheckhe-");
        }

        // ISwim

        public string UndertheSea { get; set; }

        public void Swimmies() {
            Console.WriteLine("Doin' a swim.");
        }
        
    }

}