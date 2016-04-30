using System;
namespace Tic_Tac_Toe.M {
    class Board {
        //Boards should have a MxN array of tiles.
        //Board is essentially a board controller?
        //Board handles rule enforcement.
        Tile[,] board;
        public Board(){
            board=new Tile[BoardManager.tileColumns,BoardManager.tileRows];
            for(int x = 0;x<BoardManager.tileRows;x++)
                for(int y = 0;y<BoardManager.tileColumns;y++)
                    board[x,y]=new Tile();
        }

        public Board(uint columns, uint tiles) {
            board=new Tile[columns,tiles];
            for(uint x = 0;x<BoardManager.tileRows;x++)
                for(uint y = 0;y<BoardManager.tileColumns;y++)
                    board[x,y]=new Tile();
        }

        public void setTile(Player player, string location) { //Confirm this is working
            getTile(location.Replace("button","")).Player=player;
            getTile(location.Replace("button","")).Color=player.Color;
        }

        public bool isWinner(){
            bool victoryFlag = false;
            //Check rows:
            for(int x = 0;x<3;x++) {
                if(!board[0,x].Player.Name.Equals("EMPTY")&&!board[1,x].Player.Name.Equals("EMPTY")&&!board[2,x].Player.Name.Equals("EMPTY"))
                    if(board[0,x].Player.Name.Equals(board[1,x].Player.Name)&&board[1,x].Player.Name.Equals(board[2,x].Player.Name))
                        victoryFlag=true;
            }
            //Check cols:
            for(int y = 0;y<3;y++) {
                if(!board[y,0].Player.Name.Equals("EMPTY")&&!board[y,1].Player.Name.Equals("EMPTY")&&!board[y,2].Player.Name.Equals("EMPTY"))
                    if(board[y,0].Player.Name.Equals(board[y,1].Player.Name)&&board[y,1].Player.Name.Equals(board[y,2].Player.Name))
                        victoryFlag=true;
            }
            // \
            if(!board[0,0].Player.Name.Equals("EMPTY")&&!board[1,1].Player.Name.Equals("EMPTY")&&!board[2,2].Player.Name.Equals("EMPTY"))
                if(board[0,0].Player.Name.Equals(board[1,1].Player.Name)&&board[1,1].Player.Name.Equals(board[2,2].Player.Name))
                    victoryFlag=true;
            // /
            if(!board[2,0].Player.Name.Equals("EMPTY")&&!board[1,1].Player.Name.Equals("EMPTY")&&!board[0,2].Player.Name.Equals("EMPTY"))
                if(board[2,0].Player.Name.Equals(board[1,1].Player.Name)&&board[1,1].Player.Name.Equals(board[0,2].Player.Name))
                    victoryFlag=true;

            return victoryFlag;
        }

        bool isTie(uint turns) {
            if(turns==board.Length)//Is Length 9?
                return true;
            return false;
        }

        public Tile getTile(string location) {
            //Hard code for Tic-Tac-Toe for now.
            switch(location.Replace("button","")) {
                case "NW":
                return board[0,0];
                case "N":
                return board[1,0];
                case "NE":
                return board[2,0];
                case "W":
                return board[0,1];
                case "C":
                return board[1,1];
                case "E":
                return board[2,1];
                case "SW":
                return board[0,2];
                case "S":
                return board[1,2];
                case "SE":
                return board[2,2];
                default://Don't do it like this!
                return board[1,1];
            }
        }

        public String getPosition(string location) {
            //Hard code for Tic-Tac-Toe for now.
            switch(location.Replace("button","")) {
                case "NW":
                return "[0,0]";
                case "N":
                return "[1,0]";
                case "NE":
                return "[2,0]";
                case "W":
                return "[0,1]";
                case "C":
                return "[1,1]";
                case "E":
                return "[2,1]";
                case "SW":
                return "[0,2]";
                case "S":
                return "[1,2]";
                case "SE":
                return "[2,2]";
                default:
                return $"ERROR:\nLocation: {location}.";
            }
        }
    }
}