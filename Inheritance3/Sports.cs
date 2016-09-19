using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    class Sports
    {
        private int numberOfPlayers;

        public int Players //Variable
        {
            get { return this.numberOfPlayers; }
            set { numberOfPlayers = value; }
        }

        private int numberOfCoaches; //Variable

        public int Coaches
        {
            get { return this.numberOfCoaches; }
            set { numberOfCoaches = value; }
        }
        protected double whistleVolume;  //Variable
    }
}
