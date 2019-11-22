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

        public void FrigateEspecial()
        {
        
        }

    

    }
}
