using System;
using System.Collections.Generic;
using System.Text;

namespace Length_of_line
{
    class Lengthofline
    {
        public void Calculate(int x1, int y1, int x2, int y2)
        {
            float length = 0;
            length = (float)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("length iss=" + length);
        }
    }
}
