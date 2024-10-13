using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PR4
{
    public class Shape
    {
        public double pi = 3.14;
        public double r;
        public double S;
        public double width;
        public double height;
        public double baseLength;
        public double p;



        public double CalculateArea(double r)
        {
            S = r * r * pi;
            return S;
            
        }

        public double CalculateArea(double width, double height)
        {
            S = width * height;
            return S;
        }

        public double CalculateArea(double baseLength, double height, bool isRightTriangle)
        {
            if (isRightTriangle)
            {
                return S = 0.5 * height * baseLength;
            }
            else
            {
                Console.WriteLine("Введите значение 2х других сторон");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());

                if (a + b < baseLength)
                {
                    Console.WriteLine("Такого треугольника не существует");
                    return 0;
                }
                else
                {
                    p = a + b + baseLength;
                    return S = Math.Sqrt(p * (p - a) * (p - b) * (p - baseLength));
                }

            }
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Shape shape = new Shape();

            double result = shape.CalculateArea(10);
            Console.WriteLine($"Площадь круга по радиусу равна {result}");

            result = shape.CalculateArea(10,10);
            Console.WriteLine($"Площадь прямоугольника по 2 сторонам равна {result}");

            result = shape.CalculateArea(10, 10, true);
            Console.WriteLine($"Площадь прямоугорльного треугольника равна {result}");

            result = shape.CalculateArea(10, 10, false);
            Console.WriteLine($"Площадь треугольника по теореме Герона равна {result}");

            Console.ReadLine();
        }
    }
}