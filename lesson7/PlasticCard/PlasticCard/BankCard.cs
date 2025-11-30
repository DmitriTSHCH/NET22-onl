using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class BankCard
    {
        protected string CardNumber;
        protected short Pin;
        protected long Remains = 0;

        public BankCard() 
        {
            Random randomCN = new Random(Guid.NewGuid().GetHashCode());
            CardNumber = Convert.ToString(randomCN.Next(10000000, 99999999));
            Random randomP = new Random(Guid.NewGuid().GetHashCode());
            Pin = Convert.ToInt16(randomP.Next(1000, 9999));

            Console.WriteLine($"\n------------------------------------------------------\nСодана карта\nНомер: {CardNumber}\nКод: {Pin}\n------------------------------------------------------\n");
        }
        public void SelectOperation()
        {
            Console.WriteLine($"Операции со счетом: {CardNumber}\n(1) Просмотр остатка\n(2) Снятие средств\n(3) Пополнение счета\n\n Введите номер требуемой операции: ");
            switch (Convert.ToInt32(Console.ReadLine()))
                {
                case 1:
                    PrintRemains();
                    break;
                case 2:
                    TakeOfMoney();
                    break;
                case 3:
                    PutMoney();
                    break;
                }
        }
        protected bool PinChek()
        {
            short inputPin = 0;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Попытка {i} из 3\nВведите пароль: ");
                inputPin = Convert.ToInt16(Console.ReadLine());
                if (inputPin == Pin)
                {
                    i = 10;
                }
                else 
                {
                    Console.WriteLine("Неверно");
                }
            }
            if (inputPin == Pin && inputPin != 0)
            {
                return true;
            }
            else
            { 
                return false;
            }

        }
        protected void PrintRemains()
        {
            if (PinChek())
            {
                Console.WriteLine($"\nОстаток {Remains}");
            }
            else
            {
                Console.WriteLine("Отклонено");
            }
        }
        protected void TakeOfMoney()
        {
            if (PinChek())
            {

                Console.WriteLine($"\nОстаток {Remains}\nВведите сумму к снятию: ");
                long tafeOffMoney = Convert.ToInt64(Console.ReadLine());
                if (tafeOffMoney <= Remains)
                {
                    Remains -= tafeOffMoney;
                    Console.WriteLine($"\nСнято: \nОстаток: {Remains}");
                }
                else
                {
                    Console.WriteLine("\nНедостаточно средств");
                }
            }
            else
            {
                Console.WriteLine("Отклонено");
            }
        }
        protected void PutMoney()
        {
            Console.WriteLine($"\nВведите сумму к начислению: ");
            long putMoney = Convert.ToInt64(Console.ReadLine());
            Remains += putMoney;
        }
    }

