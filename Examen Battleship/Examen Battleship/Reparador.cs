using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Battleship
{
    public class Reparador : Ship
    {
        public Reparador(int lifepoints, string name, string effect)
        {
            Lifepoints = 2;
            Name = "Reparador";
            Effect = effect;

        }
        //Especial (Metodo)

        public void ReparierEspecial()
        {

        }

    }
}
