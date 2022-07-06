using System;

namespace OperatorsInClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;


            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            
        }
    public static double AreaOfCircle(double r)
        {
        
            Console.WriteLine("Please enter the radius for the circle:");
            double radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of this circle is: {Math.Round(area, 2)}");
            return area;

        }
    }
}      
 