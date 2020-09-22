using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Example
    {
        public double abc(int x, int y)
        {
            int xx = x * x;
            double r;
            r = Math.Pow(1 + (1d / xx), x) - 12 * xx * y;
            return r;
        }
        public double plosch(int a)
        {
            int aa = a * a;
            double s = aa * Math.Sqrt(3) / 4;
            return s;
        }
        public double visota(int a)
        {
            double h = Math.Sqrt(3) / 2 * a;
            return h;
        }
        public double radvpi(int a)
        {
            double v= 2 * Math.Sqrt(3);
            double r = a / v;
            return r;
        }
        public double radopis(int a)
        {
            double r = a / Math.Sqrt(3);
            return r;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Example Bok = new Example();
            Console.WriteLine(Bok.abc(x, y));
            Console.WriteLine("Введите сторону равностороннего треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь равностороннего треугольника = " + Math.Round(Bok.plosch(a),3) + " Высота = " + Math.Round(Bok.visota(a), 3) + " Радиус вписанной = " + Math.Round(Bok.radvpi(a), 3) + " Радиус описанной = " + Math.Round(Bok.radopis(a), 3));
            Console.ReadKey();
        }
       
    }
}
