using System;

namespace EvenOrOdd
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");

            string sInput = Console.ReadLine();

            int iInput = int.Parse(sInput);

            if (iInput % 2 == 0)
            {
                Console.Write(iInput + " is even");
            }
            else
            {
                Console.Write(iInput + " is odd");
            }
        }
    }
}
