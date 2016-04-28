using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Tic_Tac_Toe.M {
    class Tile {
        //Player can only be set by a player if it is initially null
        public Player Player {
            get { return this.Player; }
            set {
                if(this.Player==null)
                    this.Player=value;
                else
                    return; //Throw some sort of error?  Cannot overwrite tile as player
            }
        }
        public Color Color { get; private set; } 

        public Tile() {
            this.Player=null;
            this.Color=Color.White;
        }
    }
}