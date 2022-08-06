using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите первое целое число. X = ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе целое число. Y = ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите код операции \n1 - сложение \n2 - вычитание \n3 - произведение \n4 - частное \nВаш выбор: ");
                int n = Convert.ToByte(Console.ReadLine());
                Console.Write("Результат = ");
                switch (n)
                {
                    case 1:
                        {
                            Console.Write(x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.Write(x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.Write(x * y);
                            break;
                        }
                    case 4:
                        {
                            Console.Write(x / y);
                            break;
                        }
                    default:
                        Console.WriteLine("Ошибка! Нет операции с указанным номером!");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Деление на 0!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                Console.ReadKey();
            
            
        }
    }
}
