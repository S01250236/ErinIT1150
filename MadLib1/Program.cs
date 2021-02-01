using System;

namespace MadLib1
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
        

            string animal1;
            string decription1;
            string car1;
            string place1;
            string name1;

            Console.Write("Type an Animal: ");
            animal1 = Console.ReadLine();

            animal1 = char.ToUpper(animal1[0]) + animal1.Substring(1);

            Console.Write("Type a discriptive word; ");
            decription1 = Console.ReadLine();

            decription1 = char.ToUpper(decription1[0]) + decription1.Substring(1);

            Console.Write("A type of car: ");
            car1 = Console.ReadLine();

            car1 = char.ToUpper(car1[0]) + car1.Substring(1);

            Console.Write("A place in the world: ");
            place1 = Console.ReadLine();

            place1 = char.ToUpper(place1[0]) + place1.Substring(1);

            Console.Write("Your name is : " );
            name1 = Console.ReadLine();

            name1 = char.ToUpper(name1[0]) + name1.Substring(1);

            Console.Write("Hello there, my name is ");
            Console.Write(name1);
            Console.Write(".");

            Console.Write("I have a pet ");
            Console.Write(animal1);
            Console.Write(".");

            Console.Write("They came from ");
            Console.Write(place1);
            Console.Write(".");

            Console.Write("A fact about them is that they are ");
            Console.Write(decription1);
            Console.Write(".");

            Console.Write("I took them home in my ");
            Console.Write(car1);
            Console.WriteLine(".");

            Console.ReadKey();
        }
     
    }
}
