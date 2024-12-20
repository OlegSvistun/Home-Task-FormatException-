using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть перше число:");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    throw new FormatException("Помилка: Невірний формат першого числа.");
                }

                Console.WriteLine("Введіть друге число:");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    throw new FormatException("Помилка: Невірний формат другого числа.");
                }

                Console.WriteLine("Введіть математичну операцію (+, -, *, /):");
                char operation = Convert.ToChar(Console.ReadLine());

                int result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            throw new DivideByZeroException("Помилка: Ділення на нуль неможливе.");
                        }
                        break;
                    default:
                        throw new InvalidOperationException("Помилка: Недійсна математична операція.");
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exeption ex)
            {
                Console.WriteLine("Сталася непередбачена помилка: " + ex.Message);
            }    

            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
}
