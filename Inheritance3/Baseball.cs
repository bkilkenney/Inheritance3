using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    class Baseball : Sports
    {
        public Baseball()
        {
            Players = 9;
            Coaches = 4;
            whistleVolume = 20.0;
            
        }
        public void Display() //Method
        {
            Console.WriteLine("Players: {0}, Coaches: {1}, Whistle Volume: {2}", Players, Coaches, whistleVolume);
        }
    }
}
