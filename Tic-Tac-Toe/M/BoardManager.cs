using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.M {
    class BoardManager {
        //Holds global values such as board tile grid .  Currently pretty useless.
        public static uint tileColumns;
        public static uint tileRows;

        public BoardManager() {
            //Can we do better than hard coding a convenient default for us?
            //What do we do if params unknown?
            tileColumns=3;
            tileRows=3;
        }
        public BoardManager(uint columnParam, uint rowParam){
            tileColumns=columnParam;
            tileRows=rowParam;
        }
    }
}
