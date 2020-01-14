using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bradford";
            string state = "California";
            DateTime currentDate = DateTime.Parse(DateTime.Now.ToString());
            string currentDateSimple = DateTime.Now.ToString("d");
            DateTime christmasDate = DateTime.Parse("12/25/2020");
            int daysUntilChristmas = (christmasDate - currentDate).Days;

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine($"My name is {name}, I am from {state}.");
            Console.WriteLine($"The current date is {currentDateSimple}.");
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas.");

            Console.WriteLine();

            Console.Write("Please input a width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please input a height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet.");
            Console.WriteLine($"The area of the glass is {glassArea} square meters.");

            Console.WriteLine();

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
