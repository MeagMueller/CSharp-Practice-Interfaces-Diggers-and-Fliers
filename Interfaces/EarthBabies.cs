using System;
using System.Collections.Generic;

namespace diggers_and_fliers {

    public interface ILiveOntheGround
        {
            string AboveGround { get; set; }

            void WalkWalkWalk();
            void HeckRun();

            void ImASnek();
        } 
}