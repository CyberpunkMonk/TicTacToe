using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.M {
    class Board {
        Tile[,] tile;
        //Boards should have a MxN array of tiles.
        //Board is essentially a tile controller?
        //Board handles rule enforcement.
        public Board() {
            //Do some checking to make sure BoardManager is set up?
            tile=new Tile[BoardManager.tileColumns,BoardManager.tileRows];
            
            //Populate board with tiles
            for(int x = 0;x<BoardManager.tileRows;x++)
                for(int y = 0;y<BoardManager.tileColumns;y++)
                    tile[x,y]=new Tile();

        }
    }
}