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
            string path = "F:/C#/Calc.txt";
            /*if (!File.Exists(path));
            {
                File.Create(path);
            }*/
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
                Sum = Sum + Convert.ToInt32(sr.ReadLine());

            }
            Console.WriteLine(Sum);
            Console.ReadKey();
            #endregion

        }
    }
}
