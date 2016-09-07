using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0406
{
    class Program
    {
        static void Main(string[] args)
        {
            string city;            // To hold the name of a city
            

            // Get the city name.
            Console.WriteLine("Denver");
            Console.WriteLine("Honolulu");
            Console.WriteLine("Minneapolis");
            Console.WriteLine("New York");
            Console.WriteLine("San Fransico");
            Console.WriteLine("Enter a city from the list above " +
                              "and I will give you the time zone");
            city = Console.ReadLine();

            // Verify the city name
            if (city == "Denver" || city == "Honolulu" ||
                city == "Minneapolis" || city == "New York" ||
                city == "San Fransico")
            {                            
                // Determine the time zone.
                switch (city)
                {
                    case "Honolulu":
                        Console.Write("Hawaii-Aleutian");
                        break;
                    case "San Fransico":
                        Console.Write("Pacific");
                        break;
                    case "Denver":
                        Console.Write("Mountain");
                        break;
                    case "Minneapolis":
                        Console.Write("Central");
                        break;
                    case "New York":
                        Console.Write("Eastern");
                        break;
                }
                Console.ReadLine();
            }
            else
            {
                // No city was entered.
                Console.WriteLine("The appropriate city was not entered");
                Console.ReadLine();
            }

        }
    }
}
