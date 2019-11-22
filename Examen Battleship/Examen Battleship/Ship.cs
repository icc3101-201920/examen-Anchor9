using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Battleship
{
    public class Ship
    {
        protected int lifepoints;
        protected string name;
        protected string effect;


        //Constructor
        public Ship()

        {

        }

        public int Lifepoints
        {   get
            {
                return this.lifepoints;
            }
            
            set
            {
                this.lifepoints = value;
            }

        }

        public string Name

        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }

        }
        public string Effect
        {
            get
            {
                return this.effect;
            }

            set
            {
                this.effect = value;
            }

        }
    }
}
