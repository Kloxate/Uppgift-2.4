using System;

namespace School_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lön för person 1");
            string Person_1 = Console.ReadLine();
            Console.WriteLine("Lön för person 2");
            string Person_2 = Console.ReadLine();
            Console.WriteLine("Lön för person 3");
            string Person_3 = Console.ReadLine();
            int Lön1 = int.Parse(Person_1);
            int Lön2 = int.Parse(Person_2);
            int Lön3 = int.Parse(Person_3);
            int Totalt = Lön1 + Lön2 + Lön3;
            int Medellön = Totalt / 3;
            Console.WriteLine(Medellön + "kr är medellönen");

        }
    }
}
