using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

    public class Copperheads : ISnek, ILiveOntheGround {

        // ISnek

        public void ImASnek() {
            Console.WriteLine("Slither, my dudes.");
        }

        // ILiveOntheGround

        public string AboveGround { get; set; }
        
    }

}