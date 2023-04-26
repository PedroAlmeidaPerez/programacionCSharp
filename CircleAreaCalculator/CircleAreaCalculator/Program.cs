using System;
namespace CircleAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            const double PI = 3.1416;
            double circleArea;
            string userData;

            Console.WriteLine("escribe el radio: ");
            userData = Console.ReadLine();

            if(double.TryParse(userData, out radio))
            {
                circleArea = PI * Math.Pow(radio, 2);
                Console.WriteLine($"El Area es: {circleArea}");
            }
            else
            {
                Console.WriteLine("la entrada es incorrecta");
            }

            
            
            Console.ReadKey();
        
        }
    }
}