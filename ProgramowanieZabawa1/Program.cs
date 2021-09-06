using System;

namespace ProgramowanieZabawa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czesc zaczynamy zabawe");
            int wykonywac = 1;

            if (wykonywac == 0)
            {
                double a, b, c;
                string liczba;
                Console.WriteLine("Podaj liczbe a");
                liczba = Console.ReadLine();
                a = Double.Parse(liczba);
                Console.WriteLine("Podaj liczbe b");
                liczba = Console.ReadLine();
                b = Double.Parse(liczba);
                c = a + b;
                Console.WriteLine(c);

                if (c > 2)
                {
                    Console.WriteLine("Nie wiem");
                }
                else
                {
                    Console.WriteLine("wiem");
                }
            }

        }
    }
}
