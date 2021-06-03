using System;

namespace Length_of_line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of line");
            Console.WriteLine("Program to calculate the length the the line");
            Lengthofline cal;
            cal = new Lengthofline();
            float Line1 = cal.Call(1, 1, 1, 2);
            float Line2 = cal.Call(1, 2, 2, 2);
            //Equals
            if (Line1.Equals(Line2) == true)
                Console.WriteLine("Lines are Equal in length");
            else
                Console.WriteLine("Lines are Not Equal");

            //compareTo
            if (Line1.CompareTo(Line2) == 0)
                Console.WriteLine("Both Line are  Same");
            else
                Console.WriteLine("They are not Same");
            Console.ReadKey();
        }
    }

}
