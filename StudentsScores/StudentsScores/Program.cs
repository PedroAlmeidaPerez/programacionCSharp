using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentsScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[]  array1 = { "Pedro", "Pablo", "Bianka", "Oliwia"};
           
            
            //insertScore(array1 as string[]);
            SortedList<string, int> sortedStudentsScores = new SortedList<string, int>();
            int score;
            Console.WriteLine("dentro de ShowArray");

            foreach (string s in array1)
            {
                Console.WriteLine($"Proporciona la nota del estudiante {s}");
                score = 0;
                while (score == 0)
                {
                    GetInteger(Console.ReadLine(), out score);
                }

                sortedStudentsScores.Add(s, score);

            }

            foreach (var item in sortedStudentsScores)
            {
                Console.WriteLine($"El estudiante {item.Key} tiene la nota {item.Value}");
            }

           







            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }

        /*private static void GetInteger(string v, object data, out int score1)
        {
            if(!int.TryParse(v, out score1))
            {
                Console.WriteLine("el dato debe ser entero");
            }
        }*/

       /* private sortedStudentsScores<Object> insertScore(string[] strings)
        {
            SortedList<string, int> sortedStudentsScores = new SortedList<string, int>();
            int score;
            Console.WriteLine("dentro de ShowArray");
           
            foreach (string s in strings)
            {
                Console.WriteLine($"Proporciona la nota del estudiante {s}");
                score = 0;
                while (score == 0)
                {
                    GetInteger(Console.ReadLine(), out score);
                }

                sortedStudentsScores.Add(s, score);

            }

            return sortedStudentsScores;


        }*/

        private static void GetInteger(string data, out int score)
        {
            if (!int.TryParse(data, out score))
                Console.WriteLine("el dato debe ser un entero");
        }
    }
}