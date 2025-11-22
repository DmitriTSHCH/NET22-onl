using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles_Arrays_Lists
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[,] matrix = CreateArray();

                matrix = RandomizeArray(matrix);

                PrintArray(matrix);
            }
            /*
            Console.WriteLine("(1);\n(2);\n(3);\nВыберите нужную последовательность(введите номер варианта): ");

            while (true)
            {
                Console.SetCursorPosition(0, 8);

                PrintArray(arr);

                for (int i = 0; i < args.Length; i++)
                {

                }



                switch (Console.ReadLine())
                {
                    case "1":
                        //
                        break;
                    case "2":
                        //
                        break;
                    case "3":
                        //
                        break;
                }
            }*/
        }
        static int[,] CreateArray ()
        {
            Console.Write("Введите числол строк матрицы (не более 5): ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.Write("\nВведите числол столбцов матрицы (не более 5): ");
            int m = Convert.ToInt16(Console.ReadLine());
            int[,] array = new int[n, m];
            return array;
        }
        static int[,] RandomizeArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Random random = new Random(Guid.NewGuid().GetHashCode());
                    array[i, j] = random.Next(-9, 9);
                }
            }
            return array;
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > -1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write($"{array[i, j]} ");
                    if (j == (array.GetLength(1)) - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}
