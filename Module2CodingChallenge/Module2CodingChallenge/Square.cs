using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Square : Polygon
    {
        // Attribute
        public float Size { get; set; }
        
        // Constructor
        public Square(float size)
        {
            Size = size;
            NumberOfSides = 4;
        }
    }
}
