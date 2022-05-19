using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //Kasutajal on kolm katset
            //*programm genereerib juhusliku numbri ühe korra. $

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Arva, mis numbri ma genereerisin:");
                int myNumber = Convert.ToInt32(Console.ReadLine());

                if (myNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale vastus.{3 - i} katset on jäänud");
                }
            }
            Console.WriteLine("Kena päeva!");

        }

    }
}