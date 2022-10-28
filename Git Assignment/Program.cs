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
                "centimeters, and 'cm'  to convert centimeters to inches.");

            String unitType = Console.ReadLine();
            while (unitType != "inches" && unitType != "centimeters")
            {
                unitType = Console.ReadLine();
            }

            Console.WriteLine("How many " + unitType + "s would you like to convert?");
            String unitAmtStr = Console.ReadLine();
            int unitAmtInt = Int32.Parse(unitAmtStr);

            if (unitType == "in") //Converts inches to centimeters
            {
                double newUnit = 2.54 * unitAmtInt;
                Console.WriteLine("You now have " + newUnit + "centimeters.");
            }

            else if (unitType == "cm") //Converts cm to inches
            {
                double newUnit = unitAmtInt / 2.54;
                Console.WriteLine("You now have " + newUnit + "inches");

            }

        }
    }
}
