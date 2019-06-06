using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

    public class Finches : IFly {

        // IFly

        public string Flybaby { get; set; }

        public void GetSomeAir() {
            Console.WriteLine("Flying the friendly skies.");
        }
        
    }

}