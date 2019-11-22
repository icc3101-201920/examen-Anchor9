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

            
            
        }

    

    }
}
