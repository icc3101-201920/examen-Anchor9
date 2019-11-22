using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Battleship
{
    public class Submarino : Ship
    {
        public Submarino(int lifepoints, string name, string effect)
        {
            Lifepoints = 3;
            Name = "Submarino";
            Effect = effect;

        }

        //Especial (Metodo)

        public void SubmarineEspecial()
        {

        }
    }
}
