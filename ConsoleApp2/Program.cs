﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int balance = 0;


            Console.WriteLine("Добро пожаловать!\nВыберите номер действия:");
            void Menu()
            {
                Console.WriteLine("1 Проверить баланс\n2 Снять деньги\n3 Внести деньги\n4 Выход");


                Console.Write("Действие номер: ");
                string choice = Console.ReadLine();
                int intchoise;
                if (int.TryParse(choice, out intchoise) && intchoise <= 4 && intchoise > 0)
                {
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Вы выбрали: Проверить баланс");
                            Console.WriteLine($"Ваш баланс: {balance}");
                            Menu();
                            break;

                        case "2":
                            Console.WriteLine("Вы выбрали: Снять деньги");
                            if (balance == 0)
                            {
                                Console.WriteLine("Недостаточно средств");
                                Menu();
                            }
                            else
                            {
                                Console.Write("Сумма снятия:");
                                string withdraw = Console.ReadLine();
                                int intwithdraw;
                                if (int.TryParse(withdraw, out intwithdraw) && intwithdraw > 0)
                                {
                                    balance = balance - intwithdraw;
                                    Console.WriteLine($"Ваш баланс: {balance}");

                                }
                                else
                                {
                                    Console.WriteLine("Введите положительное число");
                                }
                                Menu();
                            }
                            break;

                        case "3":
                            Console.WriteLine("Вы выбрали: Внести деньги");
                            Console.Write("Сумма внесения:");
                            string deposit = Console.ReadLine();
                            int intdeposit;
                            if (int.TryParse(deposit, out intdeposit) && intdeposit > 0)
                            {
                                balance = balance + intdeposit;
                                Console.WriteLine($"Ваш баланс: {balance}");
                            }
                            else
                            {
                                Console.WriteLine("Введите положительное число");
                            }
                            Menu();
                            break;

                        case "4":
                            Console.WriteLine("Выход из программы");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите число от 1 до 4");
                    Menu();
                }
            }
            Menu();

        }
    }
}
