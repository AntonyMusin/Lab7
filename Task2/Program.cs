using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            int a = Convert.ToInt32(Console.ReadLine());
            CalcAreaVolume(a);
            Console.ReadKey();
        }
        static void CalcAreaVolume(int a)
        {
            int area = a*a*6;
            int volume = a*a*a;
            Console.WriteLine("Площадь поверхности куба = {0} у.е., Объем куба = {1} у.е.", area, volume);
        }
    }
}
