using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new Dictionary<string, string>();
            countries.Add("Macedonia", "Skopje");
            countries.Add("Greece", "Athens");
            countries.Add("Denmark", "Copenhagen");
            countries.Add("Sweden", "Stockholm");
            countries.Add("Slovenia", "Ljubljana");

            foreach (var country in countries)
            {
                Console.WriteLine("Choose 1 if you want to find the capital city of country.");
                Console.WriteLine("Choose 2 if you want to add country and capital city.");

                try
                {
                    var input = Convert.ToInt32(Console.ReadLine());

                    if (input == 1)
                    {
                        Console.WriteLine("Please enter the name of the country!");
                        var choice = Console.ReadLine();

                        if (countries.ContainsKey(choice))
                        {
                            Console.WriteLine($"The capital city of {choice} is {countries[choice]}");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"There is no such country in our collection!");
                            Console.ReadLine();
                            
                        }
                    }

                    else if(input == 2)
                    {
                        Console.WriteLine("Please enter the country that you want to add!");
                        string newCountry = Console.ReadLine();
                        Console.WriteLine("Please enter the capital city of the country!");
                        string newCity = Console.ReadLine();
                        countries.Add(newCountry, newCity);
                        Console.WriteLine("The new country was added!");
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        Console.ReadLine();
                        break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
