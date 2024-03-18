using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21pp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите операцию: 1 Вывод а, 2 Вывод б 3 + 4 - 5 * 6 /");
            int chosee = Convert.ToInt32(Console.ReadLine());
            switch (chosee) 
            {
                case 1:
                    Console.WriteLine(a);
                    break;
                case 2: 
                    Console.WriteLine(b);
                    break;
                case 3:
                    int c = a + b;
                    Console.WriteLine(c);
                    break;
                case 4:
                    c = a - b;
                    Console.WriteLine(c);
                    break;
                case 5:
                    c = b * a;
                    Console.WriteLine(c);
                    break; 
                case 6:
                    c = a / b;
                    Console.WriteLine(c);
                    break;
            }



        }
    }
}
