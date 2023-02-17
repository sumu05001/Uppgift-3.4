using System;
namespace uppgift4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång låten är ?");
            Console.Write("minuter :");
            int minuter = int.Parse(Console.ReadLine());
            Console.Write("sekunder :");
            int sekunder = int.Parse(Console.ReadLine());
            int lång = (minuter * 60) + sekunder;
            if (lång >= 165 && lång <= 260)
            {
                Console.WriteLine("låten får spelas på radiostationen");
            }
            else
            {
                Console.WriteLine("låten får inte spelas på radiostationen");
            }
        }
    }
}


