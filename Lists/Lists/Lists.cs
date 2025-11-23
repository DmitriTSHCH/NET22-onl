using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles_Arrays_Lists
{
    internal class Lists
    {
        static void Main(string[] args)
        {

            List<int> list = CreateRandomList();

            Console.WriteLine(list.Count);
            PrintList(list);
            
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("(1)Создать новый лист;\n(2)Добавить элемент;\n(3)Удалить элемент;\n(4)Удвоить четные числа и приравнять нулю нечетные числа;\n(5)Создать и вывести числа по порядку без повторений по списку;\nВыберите действие(введите номер варианта): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        list = CreateRandomList();
                        break;
                    case "2":
                        Console.WriteLine("Введите добавляемое число: ");
                        list.Add(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "3":
                        Console.WriteLine("Введите порядковый номер удаляемого числа: ");
                        list.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
                        break;
                    case "4":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 == 0)
                            {
                                list[i] *= 2;
                            }
                            else
                            {
                                list[i] = 0;
                            }
                        }
                        break;
                    case "5":
                        HashSet<int> hashSet = new HashSet<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (hashSet.Contains(list[i]) == false)
                            {
                                hashSet.Add(list[i]);
                            }
                        }
                        PrintHashSet(hashSet);
                        Console.WriteLine("\nНажмите любую клавишу для продолжения.");
                        Console.ReadKey();
                        break;
                }

                PrintList(list);
            }
        }
        static List<int> CreateRandomList()
        {
            Console.Clear();
            Console.WriteLine("Введите размер списка: ");
            List<int> list = new List<int>();
            int listCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < listCount; i++)
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int randomNumber = Convert.ToInt32(random.Next(-9, 9));
                list.Add(randomNumber);
            }
            return list;
        }
        static void PrintList(List<int> list)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 12);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{i+1}) {list[i]}, ");
            }
        }
        static void PrintHashSet(HashSet<int> hashSet)
        {
            Console.Clear();
            foreach (int i in hashSet)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
