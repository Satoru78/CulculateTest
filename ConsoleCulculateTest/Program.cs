using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCulculateTest;
using CulculateTest;

namespace ConsoleCulculateTest
{
    class Program
    {
        private static int Action { get; set; }
        static void Main()
        {
            while (Action !=5)
            {
                Commands();
                Console.WriteLine("Введите команду: ");           
                Action = int.Parse(Console.ReadLine());
                switch (Action)
                {
                    case 1:
                     {
                        Console.WriteLine("Ввведите первое число:");
                        int firstnum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ввведите первое число:");
                        int secondnum = int.Parse(Console.ReadLine());
                        Console.WriteLine(Culculate.Addition(firstnum, secondnum));
                     }
                        break;
                    case 2:
                     {
                            Console.WriteLine("Ввведите первое число:");
                            int firstnum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ввведите первое число:");
                            int secondnum = int.Parse(Console.ReadLine());
                            Console.WriteLine(Culculate.Substraction(firstnum, secondnum));
                     }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Ввведите первое число:");
                            int firstnum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ввведите первое число:");
                            int secondnum = int.Parse(Console.ReadLine());
                            Console.WriteLine(Culculate.Multiplicaton(firstnum, secondnum));
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Ввведите первое число:");
                            int firstnum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ввведите первое число:");
                            int secondnum = int.Parse(Console.ReadLine());
                            Console.WriteLine(Culculate.Division(firstnum, secondnum));
                        }
                        break;
                    case 5:
                        Process.GetCurrentProcess().Kill();
                        break;

                }  
            }
           
        }

        static void Commands()
        {
           Console.WriteLine("1.Сложение");
           Console.WriteLine("2.Вычитание");
           Console.WriteLine("3.Умножение");
           Console.WriteLine("4.Деление");
           Console.WriteLine("5.Закрыть программу");

        }
    }
}
