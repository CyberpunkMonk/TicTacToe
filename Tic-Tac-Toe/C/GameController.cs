using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Tic_Tac_Toe.M;
namespace Tic_Tac_Toe.C {
    class GameController {
        List<Player> players;
        public uint Turns {
            get; set;
        }
        public GameController() {
            //Hard code default Tic-Tac-Toe for now
            players=new List<Player>();
            players.Add(new Player("Player 1",Color.Red,'X'));
            players.Add(new Player("Player 2",Color.Blue,'O'));
            Turns = 0;
        }

        //Can we simplify this without overloading?
        public bool IsPlayerNameAvailable(string name) {
            return players.Any(p => p.Name==name); //Thanks to Twitch.tv user Dante2k
        }
        public bool IsPlayerNameAvailable(Player player) {
            //What if player is null?
            return (players.Contains(player));
        }
        //Returns players turn
        public Player getTurn(Player currentPlayer) {//Rework, this can be done way better
            if(currentPlayer==players[1]) return players[0];
            else return players[1];
        }

        public bool isTie(uint turns) {
            if(Turns==9)//HARD CODED FOR TIC-TAC-TOE FIX LATER
                return true;
            return false;
        }
    }
}