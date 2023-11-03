using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenTurfing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double turf_price_sqm = 2.50; // price of turf sqm is constant
            // decalre variables
            double length;
            double breadth;
            double area;
            double turfCost;

            // welcome 
            Console.WriteLine("Welcome to the Garden Turfing Cost Calculator");

            Console.Write("Please enter the length of your garden (in meters): ");
            length = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Please enter the breadth of your garden (in meters): ");
            breadth = Convert.ToDouble(Console.ReadLine());

            area = length * breadth; // calculate area
            turfCost = area * turf_price_sqm; // calculate total cost

            // confirmation
            Console.WriteLine($"The area of your garden is {area} square meters.");
            Console.WriteLine($"The total cost of turfing your garden is £{turfCost:F2}.");

            // conditional if cost can be covered by grant. Only £75 and below can be covered
            if (turfCost > 75)
            {
                Console.WriteLine("This cost cannot be covered by a grant.");
            }
            // thankyou
            Console.WriteLine("Thank you for using the Garden Turfing Cost Calculator!");
        
            Console.ReadKey();
        }
    }
}
