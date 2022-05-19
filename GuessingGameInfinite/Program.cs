using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhusliku numbri ühe korra. $

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while ()
            {
                Console.WriteLine("Arva, mis numbri ma genereerisin:");

                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud!");
                    break;

                }

            }
        }
    }
}
