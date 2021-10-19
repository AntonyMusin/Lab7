using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сначала длины трех сторон первого треугольника, а затем второго:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double S1= CalcArea1(a1, b1, c1);
            double S2 = CalcArea2(a2, b2, c2);
            Console.WriteLine("Площадь треугольника №1= {0} у.е.,Площадь треугольника №2= {1} у.е.",S1, S2);
            if (S1>S2)
            {
                Console.WriteLine("Треугольник №1 больше чем треугольник №2");
            }
            else if (S2>S1)
            {
                Console.WriteLine("Треугольник №2 больше чем треугольник №1");
            }
            else
            {
                Console.WriteLine("Площадь треугольников равна");
            }
            Console.ReadKey();
        }
        static double CalcArea1(int a1, int b1, int c1)
        {
            int per1 = a1 + b1 + c1;
            double p1 = per1 / 2;
            double S1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            return S1;
        }
        static double CalcArea2(int a2, int b2, int c2)
        {
            int per2 = a2 + b2 + c2;
            double p2 = per2 / 2;
            double S2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
            return S2;
        }
    }
}
