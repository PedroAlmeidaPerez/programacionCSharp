using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentsScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            string[]  array1 = { "Pedro", "Pablo", "Bianka", "Oliwia"};
            SortedList<string, int> sortedStudentsScores = new SortedList<string, int>();
            
            ShowArray(array1 as string[]);

            

            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }

        private static void ShowArray(string[] strings)
        {
            Console.WriteLine("dentro de ShowArray");
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}