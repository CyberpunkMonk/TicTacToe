namespace Tic_Tac_Toe.M {
    class BoardManager {
        public static uint tileColumns;
        public static uint tileRows;
        public Board board;

        public BoardManager() {
            //Hard coded to setup 3x3, can be overloaded
            tileColumns=3;
            tileRows=3;
            board=new Board(tileColumns,tileRows);
        }
        public BoardManager(uint columnParam, uint rowParam){
            tileColumns=columnParam;
            tileRows=rowParam;
            board=new Board(columnParam,rowParam);
        }

        public Tile getTile(string location) {
            return board.getTile(location);
        }

        public bool isWinner() {
            return board.isWinner();
        }

        public void Reset() {
            board=new Board(3,3);
        }
    }
}