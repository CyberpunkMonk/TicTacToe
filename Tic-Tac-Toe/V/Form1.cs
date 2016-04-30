using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tic_Tac_Toe.M;
using Tic_Tac_Toe.C;
namespace Tic_Tac_Toe {
    public partial class MainForm:Form {
        private GameController gamecontroller;
        private BoardManager boardmanager;
        private Dictionary<string,Button> buttons;
        private Player currentTurn;
        public MainForm() {
            InitializeComponent();
            buttons=new Dictionary<string,Button>();
            gamecontroller=new GameController();
            boardmanager=new BoardManager(3,3);
            buttonAssembly();
            currentTurn=gamecontroller.getTurn(null);
            //buttonNW.Click+=new EventHandler(this.Button_Click);
            //buttonAssembly(); //Should buttons be initialized first?
            //Foreach button in boardmanager - susbcribe to Button_Click
            //foreach(KeyValuePair<string,Button> b in buttons) {
            //    b.Value.Click+=new EventHandler(this.Button_Click);
            //}
            //buttons.Add("NW",buttonNW);
        }

        //Make a GetTile button that takes sender (button) as input and returns board as output.
        Tile getTile(Object sender,EventArgs e) {
            Button button = sender as Button;
            return this.boardmanager.getTile(button.Name.Replace("button",""));
        }

        //Make a function that redraws the boardmanagers board data
        private void drawBoard() {

        }

        //Make a helper function that maps buttons to buttons and tiles
        private void buttonAssembly() {
            buttons.Add("NW",this.buttonNW);
            buttons.Add("N",this.buttonN);
            buttons.Add("NE",this.buttonNE);
            buttons.Add("W",this.buttonW);
            buttons.Add("C",this.buttonC);
            buttons.Add("E",this.buttonE);
            buttons.Add("SW",this.buttonSW);
            buttons.Add("S",this.buttonS);
            buttons.Add("SE",this.buttonSE);
        }

        //Handle buttons being clicked
        void Button_Click(Object sender,EventArgs e) {
            //TODO - Make sure tile not already set
            //-Clicking on an already claimed tile should just return immediately, don't even transition from the turn.
            Button button = sender as Button;

            //If button is set to a player, ignore click
            if(!boardmanager.getTile(button.Name).Player.Name.Equals("EMPTY"))
                return;
            this.currentTurn=gamecontroller.getTurn(currentTurn);

            //Set values in boardmanager's board
            boardmanager.board.setTile(currentTurn,button.Name);
            //boardmanager.board.setTile(currentTurn,button.Name);

            //Set values of button in Form1 - Or have DrawBoard method?
            //button.Text=boardmanager.board.getPosition(button.Name);
            //button.Text=boardmanager.getTile(button.Name).Player.Name;
            button.Text=boardmanager.getTile(button.Name).Player.Symbol.ToString();
            button.ForeColor=boardmanager.getTile(button.Name).Color;

            if(boardmanager.isWinner()) {
                MessageBox.Show($"{currentTurn.Name} is the winner!");
                Reset();
            }
            if(gamecontroller.isTie(gamecontroller.Turns)) {
                MessageBox.Show($"Draw game!  Restarting...");
                Reset();
            }
            gamecontroller.Turns++;

            //If game is draw - Display draw message & reset
        }

        void Reset() {
            boardmanager.Reset();
            //Reset the form
            foreach(KeyValuePair<string,Button> b in buttons) {
                b.Value.Text="";
            }
            gamecontroller.Turns=0;
        }
    }
}