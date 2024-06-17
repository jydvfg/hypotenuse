﻿namespace hypothenuse_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //sum of the multplication of each side by itself

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("The hypotenuse is: " + c);

            Console.ReadKey();  
        }
    }
}
