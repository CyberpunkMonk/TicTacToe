using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.M;
namespace Tic_Tac_Toe.V {
    class TTTPlayer:Player {
        public char Symbol {
            get; private set;
        }

        public TTTPlayer(String name,Color color) : base(name,color) {}
        public TTTPlayer(char symbol,string name, Color color):base(name,color){
            this.Symbol=symbol;
        }


    }
}
