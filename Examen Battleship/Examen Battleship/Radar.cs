using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Battleship
{
    public class Radar : Ship
    {
        public Radar(int lifepoints, string name, string effect)
        {
            Lifepoints = 1;
            Name = "Radar";
            Effect = effect;

        }

        //Especial (Metodo)

        public void RadarEspecial()
        {

        }
    }
}
