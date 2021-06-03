using System;

namespace Length_of_line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of line");
            Lengthofline Length = new Lengthofline();
            float Line1 = Length.Calculate(1, 1, 1, 2);
            float Line2 = Length.Calculate(1, 2, 2, 2);
            Boolean Check_equality = Line1.Equals(Line2);
            if (Check_equality == true)
            {
                Console.WriteLine("Lines are Equal in length");
            }
            else
            {
                Console.WriteLine("Lines are Not Equal");
            }

            float Compare = Line1.CompareTo(Line2);
            if (Compare == 0)
            {
                Console.WriteLine("Both Line are  Same");
            }
            else
            {
                Console.WriteLine("They are not Same");
            }
            Console.ReadKey();
        }
    }

}
