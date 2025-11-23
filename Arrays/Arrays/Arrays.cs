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
            int[,] matrix = CreateArray();
            matrix = RandomizeArray(matrix);
            PrintArray(matrix);

            while (true)
            {
                PrintArray(matrix);
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("(1)Создать новую матрицу;\n(2)Подсчитать количество положительных и отрицательных чисел;\n(3)Оставить только четные значения в четных строках и нечетные - в нечетных строках;\n(4)Подсчет количества различных чисел в матрице.\n\nВыберите действие(введите номер варианта): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        matrix = CreateArray();
                        matrix = RandomizeArray(matrix);
                        break;
                    case "2":
                        int quantityPositiveNumber = 0;
                        int quantityNegativeNumber = 0;
                        foreach (int i in matrix)
                        {
                            if (i > 0)
                            {
                                quantityPositiveNumber++;
                            }
                            else if (i < 0)
                            {
                                quantityNegativeNumber++;
                            }
                        }
                        PrintArray(matrix);
                        Console.SetCursorPosition(0, 7);
                        Console.WriteLine($"Количество положительных: {quantityPositiveNumber}\nКоличество отрицательных: {quantityNegativeNumber}\nКоличество нулей: { matrix.Length - (quantityPositiveNumber + quantityNegativeNumber) }\nНажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case "3":
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if ((matrix[i, j] % 2) == 0 && i % 2 != 0)
                                {
                                    matrix[i, j] = 0;
                                }
                                else if ((matrix[i, j] % 2) != 0 && i % 2 == 0)
                                {
                                    matrix[i, j] = 0;
                                }
                            }
                        }
                        PrintArrayWithoutZero(matrix);
                        Console.SetCursorPosition(0, 7);
                        Console.WriteLine($"Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                    case "4":
                        var quantityAllNumbers = new Dictionary<int, int>()
                        { [0] = 0 };
                        foreach (int i in matrix)
                        {
                            if (quantityAllNumbers.ContainsKey(i))
                            {
                                quantityAllNumbers[i]++;
                            }
                            else
                            {
                                quantityAllNumbers.Add(i, 1);
                            }
                        }

                        PrintArray(matrix);
                        Console.SetCursorPosition(0, 7);

                        foreach (var v in quantityAllNumbers)
                        {
                            Console.WriteLine($"Число: {v.Key} находится в матрице {v.Value}");
                        }

                        Console.WriteLine($"Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static int[,] CreateArray()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            int n, m;
            do
            {
                Console.Write("Введите числол строк матрицы (не более 5): ");
                n = Convert.ToInt16(Console.ReadLine());
            }
            while (n > 5 | n < 1);
            do
            {
                Console.Write("\nВведите числол столбцов матрицы (не более 5): ");
                m = Convert.ToInt16(Console.ReadLine());
            }
            while (m > 5 | m < 1);
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
            Console.Clear();
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
        static void PrintArrayWithoutZero(int[,] array)
        {
            Console.Clear();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > -1)
                    {
                        Console.Write(" ");
                    }

                    if (array[i, j] == 0)
                    {
                        Console.Write($"* ");
                    }
                    else
                    {
                        Console.Write($"{array[i, j]} ");
                    }

                    if (j == (array.GetLength(1)) - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}
