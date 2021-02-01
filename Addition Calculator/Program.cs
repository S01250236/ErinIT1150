using System;

namespace Addition_Calculator
{
    class Program
    {
        static void Main(string[] args)

        {
            SayHi();
            Console.ReadLine();



        }

        static void SayHi()
        {

            double x;
            double y;
            double z;

            x = 10;
            y = 6;
            z = x + y; 


            Console.Write("Z is: ");
            Console.Write(z);


            Console.ReadKey();



        }
    }

}


