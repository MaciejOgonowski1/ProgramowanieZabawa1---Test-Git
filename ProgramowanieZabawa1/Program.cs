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
            /* Komentarz
             * 
             */
            // sbyte -128 -> 127
            sbyte znak = 127;
            // short -32768 -> 32767
            // int -2mld -> 2mld 4 bajty
            // long -2^63 do 2^63-1 8 bajtów
            // byte - 0 do 255 na 8 bitach
            // ushort (unsigned) - 0 : 65535

            /*
             * Zmienno przecinkowe
             * float 7 znaków po przecinku
             * 
             * double od 15-16
             * decimal 28 znaków po przecinku
             * 
             * 
             * boolean True/False
             * 
             */
            float zmienna = 2.1234567890F;
            Console.WriteLine(zmienna);

            Boolean PrawdaFalsz;
            PrawdaFalsz = true;
            Console.WriteLine(PrawdaFalsz);

            // String
            String imie = "Maciek";
            Console.WriteLine(imie);

            //Test local Branch

        }
    }
}
