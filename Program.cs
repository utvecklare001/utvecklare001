using System;
using System.Collections.Generic;

namespace Forms0
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // skapar en lista av strängar
            var länder = new List<string>();

            länder.Add("Norge");
            länder.Add("Danmark");
            länder.Add("Island");
            länder.Add("Finland");
            länder.Add("Grönland");

            // loopa igenom listelementen med en foreach-loop  
            foreach (var land in länder)
            {
                Console.WriteLine(land);
            }
        }
    }
}
