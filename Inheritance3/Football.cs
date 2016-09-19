using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    class Football : Sports
    {
        public Football()
        {
            Players = 11;
            Coaches = 6;
            whistleVolume = 25.0;
        }
        public void Display() //Method
        {
            Console.WriteLine("Players: {0}, Coaches: {1}, Whistle Volume: {2}", Players, Coaches, whistleVolume);
        }
    }
}
