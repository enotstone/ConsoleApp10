using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Act 8.1 
            /*
            DirectoryInfo dir = new DirectoryInfo("F:/C#/ConsoleApp1");
            Console.WriteLine("============Список каталогов=============");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("==Список подкаталогов==");
                foreach (var it in item.GetDirectories())
                    Console.WriteLine(it.Name);
                Console.WriteLine();
            }
            Console.WriteLine("==============Список файлов==============");
            foreach (var item in dir.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();  */
            #endregion
            #region //Act 8.2
            /*
            string path = "F:/C#/Calc.txt";

            Random rnd = new Random();
            
            StreamWriter sw = new StreamWriter(path,true);
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(rnd.Next(100));
                
            }
            sw.Close();

            StreamReader sr = new StreamReader(path);
            int Sum = new int();
            for (int i = 0; i < 10; i++)
            {
                Sum += Convert.ToInt32(sr.ReadLine());

            }
            Console.WriteLine(Sum);
            Console.ReadKey();  */
            #endregion

            #region //Act 9

            
            Console.WriteLine(" Введите число");
            double Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите действие (символы +,-,*,/)");
            string Act = Console.ReadLine();
            Console.WriteLine(" Введите число");
            double Num2 = Convert.ToDouble(Console.ReadLine());
            

                switch (Act)
                {
                    case "/":
                        {
                            if (Num2 != 0)

                                Console.WriteLine(Num1 / Num2);
                            else
                                Console.WriteLine("Ошибка: Деление на ноль");
                        break;
                        }
                    case "*":
                        {
                            Console.WriteLine(Num1 * Num2);
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine(Num1 - Num2);
                            break;
                        }
                    case "+":
                        {
                            Console.WriteLine(Num1 + Num2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Не правильный символ действия");
                            break;
                        }

                }

            

            Console.ReadKey();
            #endregion
        }
    }
}
