using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: "); // Write instead of WriteLine keeps the input on the same line 
            double radius = double.Parse(Console.ReadLine()); 
            //string input = Console.ReadLine(); // input by default is string
            //double radius = double.Parse(input); // convert the string input to data type 'double' (aka float in JS)

            // add validation if radius input is actually a string or symbol, not a number

            while (radius <= 0) // while loop to validate that the radius input is greater than zero
            {
                Console.Write("Invalid entry. Please enter a positive number for radius: ");
                radius = double.Parse(Console.ReadLine());
                //input = Console.ReadLine();
                //radius = double.Parse(input);
            }

            double area = Math.PI * radius * radius; // calculate the area after validating the radius input as greater than zero
            Console.Write("The area of a circle with radius " + radius + " is: " + Math.Round(area,3)); // output the result rounded to three decimal places
            Console.ReadLine(); // keep the command window open after output
        }
    }
}
 