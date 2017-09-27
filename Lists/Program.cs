using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myCars = new List<string>();
            myCars.Add("Toyota");
            myCars.Add("BMW");
            myCars.Add("Skoda");
            myCars.Add("Audi");
            Console.WriteLine("I have these cars:");
            foreach (string car in myCars)
            {
                
                Console.WriteLine(car);
            }
            Console.WriteLine("What car do you have?");
            var usersCar = Console.ReadLine();

            myCars.Add(usersCar);

            Console.WriteLine("Your car is added to my list and now contains:");

            foreach (string car in myCars)
            {

                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }
}
