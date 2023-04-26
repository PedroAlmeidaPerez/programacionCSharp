using System;
namespace MenuSumaRestaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool isExit = false;
            double firstData, secondData, result;


            while (!isExit)
            {

                Console.Clear();
                Console.WriteLine("Escribe una opcion");
                Console.WriteLine("1 Sumar");
                Console.WriteLine("2 Restar");
                Console.WriteLine("3 Salir");

                opcion = GetIntegerDataFromUser("proporciona la opcion que deseas ejecutar: ");

                Console.WriteLine($"esta es la opcion: {opcion}");

                switch (opcion)
                {
                    case 1:
                        //suma
                      
                        firstData  = GetDoubleDataFromUser("escribe primer data");
                        secondData = GetDoubleDataFromUser("escribe el segundo data");

                        result = firstData + secondData;
                        Console.WriteLine($"La suma es: {result}");
                        break;
                    case 2:
                        Console.WriteLine("opcion 2");
                        firstData = GetDoubleDataFromUser("escribe primer data");
                        secondData = GetDoubleDataFromUser("escribe el segundo data");

                        result = firstData - secondData;
                        Console.WriteLine($"La resta es: {result}");
                        break;
                    case 3:
                        isExit = true;
                        break;
                    default:
                         break;
                }

                Console.WriteLine("FIN PROGRAMA");
                Console.ReadKey();
            }
        }

        private static double GetDoubleDataFromUser(string message)
        {
            double data = 0;
            string intData;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine($"Dentro de getdouble data ({message})");
                intData = Console.ReadLine();
                if (!double.TryParse(intData, out data))
                {
                    Console.WriteLine("no es un numero");
                }
                else
                {
                    isDataValid = true;
                }
            }
            

            return data;
        }

        private static int GetIntegerDataFromUser(string message)
        {
            string dataIn;
            int data = 0;
            bool isDataValid = false;

           
            while (!isDataValid)
            {
                Console.WriteLine(message);
                dataIn = Console.ReadLine();
                if (!int.TryParse(dataIn, out data))
                {
                    Console.WriteLine("Vuelve a introducir un valor valido: ");
                }
                else
                {
                    isDataValid = true;
                }

            }
            

            return data;
        }
    }
}