using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Tic_Tac_Toe.M;
namespace Tic_Tac_Toe.C {
    class GameController {
        uint numPlayers;
        //Dictionary<string,Player> players; //Consider list for easy turn tracking
        List<Player> players;
        BoardManager boardManager;
        Board board;
        bool turn;//AWFUL WAY OF DOING THINGS FIX THIS LATER!

        public GameController() {
            //Hard code default Tic-Tac-Toe for now
            uint numPlayers = 2;//Necessary?  Players.sizeOf could make redundant
            players.Add(new Player("Player 1",Color.Red));
            players.Add(new Player("Player 2",Color.Blue));
            //players.Add("Player 1",new Player("Player 1",Color.Red));
            //players.Add("Player 2",new Player("Player 2",Color.Blue));
            BoardManager boardManager = new BoardManager(3,3);
            board=new Board();//When GameController is made, board is ready to go.
        }

        //Constructor for when we want to add custom players?

        public bool IsPlayerNameAvailable(string name) {
            return players.Any(p => p.Name==name); //Thanks to Twitch.tv user Dante2k
        }
        public bool IsPlayerNameAvailable(Player player) {
            //What if player is null?
            return (players.Contains(player));
        }

        //FIX CURRENT TURN IT IS A MESS.

        /// <summary>
        /// Called at end of turn or beginning of game to determine who gets the spotlight
        /// </summary>
        //public Player currentTurn() {
           // if(turn==true) return 
            /*if(lastPlayer.Equals(null)) {
                //Assume players won't be empty for now?
                Random rand = new Random();
                lastPlayer=players.ElementAt(rand.Next(0,players.Count-1)).Name;
                /*var rand = new Random();
                var randomValue = players.ElementAt(rand.Next(0,players.Count));
                lastPlayer=randomValue.Key;
                return randomValue.Value;*/
            /*}
            if(lastPlayer=="Player 1") return 
            //If game hasn't started:
            //Randomly decide one

            //If game is in session:
            //When called, return next player*/

            //If last turn?  Does GameController handle this here?
        //}
    }
}