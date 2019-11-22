using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Battleship
{
    public class Portaviones : Ship
    {
        public Portaviones(int lifepoints, string name, string effect)
        {
            Lifepoints = 5;
            Name = "Portaviones";
            Effect = effect;

        }

        //Especial (Metodo)

        public void CarrierEspecial()
        {

        }
    }
}
