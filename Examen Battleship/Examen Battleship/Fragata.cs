using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Battleship
{
    public class Fragata : Ship
    {

        public Fragata(int lifepoints, string name, string effect)
        {
            Lifepoints = 4;
            Name = "Fragata";
            Effect = effect;
            

        }

        //Especial (Metodo)

        public void FrigateEspecial(Board board, string coord)
        {
            //Hacer que la coordenada dada se relacione con las casillas de su alrededor
            // Coord ej A1 = 1,1    E3 = 5,1
            // coordenada = a,b --> puntos a buscar = a-1,b-1  a-1,b   a-1, b+1 y asi sucesivamente

            string[] each;
            string word;
            string number;
            each = coord.Split();
            word = each[0];
            number = each[1];

            for(int a = 0, a < 10; a++)
            {
                for (int b = 0, a < 10, b++)


            }

            






            
            
        }

    

    }
}
