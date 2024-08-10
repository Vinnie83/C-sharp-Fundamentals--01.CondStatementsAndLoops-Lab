﻿namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;


            if (minutes > 59 )
            {
                hours++;
                minutes -= 60;
                if ( hours > 23 )
                {
                    hours = 0;
                }

            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }

        }
    }
}