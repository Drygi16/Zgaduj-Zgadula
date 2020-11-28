using System;

namespace Zgaduj_Zgadula
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int los = rnd.Next(1, 11);

            int mojaLiczba;
            int ileRazy = 0;

            Console.WriteLine("Zgadnij iczbę z zakresu 1-10");
            do
            {

                ileRazy++;
                Console.Write("Podaj liczbę: ");
                mojaLiczba = int.Parse(Console.ReadLine());
                if (mojaLiczba > 10 || mojaLiczba < 1)
                {
                    Console.WriteLine("Liczba spoza zakresu");
                }
                else
                {


                    if (mojaLiczba > los)
                    {
                        Console.WriteLine("Podałeś zbyt dużą liczbę!");
                    }
                    else if (mojaLiczba < los)
                    {
                        Console.WriteLine("Podałeś zbyt małą liczbę!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Brawo odgadłeś moją liczbę!!! Za {0} razem", ileRazy);
                    }
                }
            } while (los != mojaLiczba);






            Console.ReadKey();
        }
    }
}
