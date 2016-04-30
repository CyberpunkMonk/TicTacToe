using System.Drawing;
namespace Tic_Tac_Toe.M {
    class Tile {
        public Player Player {get; set;}
        public Color Color {get;set;} 

        public Tile() {
            this.Player=new Player("EMPTY",Color.White,'-');
            this.Color=Color.White;
        }

        public Tile(Player player, Color color) {
            Player=player;
            Color=color;
        }
    }
}