using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the unit you would like to convert. Type 'in' to convert inches to " +
                "centimeters, 'cm'  to convert centimeters to inches, 'mt' to convert meters to feet, and 'ft' to convert feet " +
                "to meters.");

            String unitType = Console.ReadLine();
            while (unitType != "inches" && unitType != "centimeters")
            {
                unitType = Console.ReadLine();
            }

            Console.WriteLine("How many " + unitType + " would you like to convert?");
            String unitAmtStr = Console.ReadLine();
            float unitAmtInt = Int32.Parse(unitAmtStr);

			switch (unitType)
			{
                case "in":
                    Console.WriteLine("You now have " + (2.54 * unitAmtInt) +  " centimeters.");
                    break;
                case "cm":
                    Console.WriteLine("You now have " + (unitAmtInt / 2.54) + " inches.");
                    break;
                case "m":
                    Console.WriteLine($"You now have {unitAmtInt * 3.281} feet");
                    break;
                case "ft":
                    Console.WriteLine($"You now have {unitAmtInt / 3.281} meters");
                    break;
            }
            Console.ReadLine();
        }

		private static void printConversion(string input, string desc)
		{
            Console.WriteLine("{0, -10} {1, 20}", input, desc);
        }
    }
}
