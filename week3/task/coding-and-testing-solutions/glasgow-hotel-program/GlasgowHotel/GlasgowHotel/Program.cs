using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasgowHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            const int tariff = 75; // constant
            string guest_name;
            int number_of_nights;
            double total_cost;

            // welcome to user
            Console.WriteLine("Welcome to the Hotel Booking System");

            Console.Write("Please enter your name: ");
            guest_name = Console.ReadLine();// assign users name to variable

            Console.Write("How many nights are you staying? ");
            number_of_nights = Convert.ToInt32(Console.ReadLine()); // convert to integer

            total_cost = number_of_nights * tariff; // calculate number of nights

            // confirmation to user
            Console.WriteLine("\nInvoice for " + guest_name);
            Console.WriteLine("Number of Nights: " + number_of_nights);
            Console.WriteLine("Total Cost: £" + total_cost);

            Console.WriteLine("\nThank you for choosing our hotel. Have a pleasant stay!");

            Console.ReadKey();
        }
    }
}
