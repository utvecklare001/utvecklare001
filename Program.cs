﻿using System;
using System.Collections.Generic;

namespace Lista_Färger
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("En liten färglista");

            List<string> färger = new List<string>();

            Console.WriteLine("Du får nu skriva en ett valfritt antal färger. Avsluta körningen med en tom rad");
            string nyFärg = " ";
            while (nyFärg != "")
            {
                Console.WriteLine("Skriv in en ny färg!");
                nyFärg = Console.ReadLine();

                färger.Add(nyFärg);

            }

            Console.WriteLine("Här är de färger du skrev in");
            //     färger.Sort(); //sorterar efter bokstavsordning

            foreach (string färg in färger)
            {
                Console.WriteLine(färg);
            }

        }
    }
}
