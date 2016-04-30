using System.Drawing;
namespace Tic_Tac_Toe.M {
    class Player {
        public string Name {
            get; private set; //Check for null values
        }
        public Color Color {
            get; private set; //Check for null values
        }
        public char Symbol {
            get; private set; //Check for null values
        }
        public Player(string name, Color color,char symbol) {
            if(name!=null) this.Name=name; //Consider throwing exception when null or used?
            if(color!=null)this.Color=color;
            if(symbol!=null)this.Symbol=symbol;
        }
    }
}