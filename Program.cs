using System;


namespace BerekeningTarief
{

    class Program
    {
        static void Main()
        {

            int leeftijd;

            leeftijd = int.Parse(Console.ReadLine());
            if (leeftijd >= 18)
            {
                Console.WriteLine("Toegelaten");
            }
            else
            {
                Console.WriteLine("Niet toegelaten");
            }

            string check = leeftijd >= 18 ? "true" : "false";
            Console.WriteLine(check);
        }
    }
}



