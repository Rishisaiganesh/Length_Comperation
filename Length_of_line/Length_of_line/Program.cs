using System;

namespace Length_of_line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of line");
            Lengthofline Length = new Lengthofline();
            Length.Calculate(1, 1, 1, 1);
            Console.ReadKey();
        }
    }
}
