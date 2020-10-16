using System;

namespace TestIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int num1;
                int num2;
                string ErrorMessage = "Некорректное значение, введите целое число";
                Console.WriteLine("Привет, давай сравним два числа. Введи первое число");
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out num1);
                if (result == true) 

                {
                    Console.WriteLine("Хорошо. Теперь введи второе число.");
                    if (int.TryParse(Console.ReadLine(), out num2))
                    {                                              
                            if (num1 > num2)
                            {
                                Console.WriteLine($"Число {num1} больше числа {num2}");
                            }
                            else
                            {
                                if (num1 < num2)
                                { Console.WriteLine($"Число {num2} больше числа {num1}"); }
                                else
                                {
                                    if (num1 == num2) 
                                    Console.WriteLine($"Число {num1} равно числу {num2}");
                                };
                                Console.WriteLine("Мы сравнили два числа. Нажмите Enter для выхода.");
                                Console.ReadLine();
                                return;



                            }
                        Console.WriteLine("Мы сравнили два числа. Нажмите Enter для выхода.");
                        Console.ReadLine();
                    } return;
                }
                Console.WriteLine(ErrorMessage);
                Console.WriteLine("Нажмите клавишу Enter");
                Console.ReadLine();
            } } } }
