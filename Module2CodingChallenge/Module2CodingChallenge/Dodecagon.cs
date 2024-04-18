using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Dodecagon : Polygon
    {
        //attributes
        public float Size { get; set; }

        //constructor
        public Dodecagon(float size)
        {
            Size = size;
            NumberOfSides = 18;
        }
    }
}
