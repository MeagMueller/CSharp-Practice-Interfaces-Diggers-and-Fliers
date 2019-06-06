using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

    public class BettaFish : ISwim {
        public string UndertheSea { get; set; }

        public void Swimmies() {
            Console.WriteLine("Thanks I live here.");
        }
    }

}