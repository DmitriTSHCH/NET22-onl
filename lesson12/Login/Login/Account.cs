using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Account
    {
        protected static string Login;
    
        protected static string ConfirmPassword;

        static Account()
        {
            do
            {
                try
                {
                    Console.WriteLine("Введите логин: ");
                    Login = Console.ReadLine();
                    if (Login.Length > 19 || Login.Length < 4)
                    {
                        throw new WrongLoginException("Длина логина должна быть от 4 до 19 символов");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }
            while (Login.Length > 19 || Login.Length < 4);
            do
            {
                try
                {
                    Console.WriteLine("Введите пароль: ");
                    ConfirmPassword = Console.ReadLine();
                    if (ConfirmPassword.Length > 19 || ConfirmPassword.Length < 8)
                    {
                        throw new Exception("Длина пароля должна быть от 8 до 19 символов");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }
            while (ConfirmPassword.Length > 19 || ConfirmPassword.Length < 8);

            bool isPasswordConfirm = false;

            do
            {
                try
                {
                    Console.WriteLine("Введите пароль повторно: ");
                    
                    if (Console.ReadLine() != ConfirmPassword)
                    {
                        throw new WrongPasswordException("Неверный пароль");
                        isPasswordConfirm = false;
                    }
                    else
                    {
                        isPasswordConfirm = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }
            while (!isPasswordConfirm);

        }
    }
}
