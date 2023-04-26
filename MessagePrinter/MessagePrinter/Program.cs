using System;
namespace MessagePrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string message = String.Empty;
            string Message = String.Empty;
            Console.WriteLine("Write a message");
            message = Console.ReadLine();
            
            Console.Write("Este es el mensaje: " + message);
            Console.Write("Este es el segundo mensaje: " + Message);
            Console.ReadKey();
        }
    }
}