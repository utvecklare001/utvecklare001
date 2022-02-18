using System;
using System.Collections.Generic;

namespace Lista_Heltal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int heltal = 0;
            Console.WriteLine("Ange ett heltal:");
            string tal1 = Console.ReadLine();// tal1 är datatypen string


            Int32.TryParse(tal1, out heltal);
            //tal1 (datatypen string) omvandlas till heltal och av datatypen int (och returnerar 0 vid felaktigt format, t.ex 3.5)

            Console.WriteLine("Nu är jag int..." + heltal);

        }
    }
}
