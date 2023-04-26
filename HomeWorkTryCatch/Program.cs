using System;
using System.Timers;

namespace HomeWorkTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string inData;
            int num;

            num = GetNumber("Introduce el numero a dividir por 100");
            Console.WriteLine($"el numero introducido es {num}");

            OperacionDivisor(num);

            Console.WriteLine("Fin del Programa");
            Console.ReadKey();
        }

        private static void OperacionDivisor(int num)
        {
            double result;

            result = 100/ num;
            Console.WriteLine($"El numero divido por 100 es {result}");
        }

        private static int GetNumber(string v)
        {
            int num = 0;
            bool intTrue = false;
            string intData;

            while (!intTrue)
            {
                Console.WriteLine(v);
                intData = Console.ReadLine();

                if (!int.TryParse(intData, out num))
                {
                    Console.WriteLine("introduce un numero");
                }
                else
                {
                    intTrue = true;
                }
            }
            

            return num;
        }
    }
}