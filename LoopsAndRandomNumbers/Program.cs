﻿using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada pin-koodi;
            //programm võrdleb sisestatud pin-koodi arvuga 1234
            //kui sisestatud pin-kood on 1234 siis konsool kuvab "Tere tulemast!";
            //kui sisestatud pin-kood on midagi muud  siis konsool kuvab "Vale PIN. Proovi uuesti";
            //kasutajal on kolm katset. i < 3

            int i = 0; //i - interation

            while (i < 3) //While- loop >> i = 1; 1 < 3 --> true; 2 < 3 --> true; 3 < 3 --> false;
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //(i = i + 1) == i++
                    i++;
                    Console.WriteLine($"Vale PIN.{3 - i} katset on jäänud.");
                }
            }
   
            Console.WriteLine("Kena Päeva!");
        }
    }
}
