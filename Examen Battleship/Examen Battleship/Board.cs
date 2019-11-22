using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Battleship
{
    public class Board
    {
        private string coord;
        private int[,] board;

        public string Coord
        {
            get
            {
                return this.coord;
            }

            set
            {
                this.coord = value;
            }

        }

        public int[,] BoardGame
        {
            get
            {
                return this.board;
            }

            set
            {
                this.board = value;
            }

        }

        public Board()

        {
            //Matriz = tablero de 10 x 10, ahora hay que rellenarla con valores (0 y 1 mas facil)
            this.board = new int[10, 10];
            int[,] tableroJuego = { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };

        }

        //Metodos 

        
        //Marca en el tablero donde está el misil que llega
        public void MarkShot()
        {

        }

        




        
    }
}
