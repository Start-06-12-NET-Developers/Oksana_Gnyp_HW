using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        public double side1, side2;

        public double Area
        {
            get
            {
                return AreaCalc();
            }
        }

        public double Perimetr
        {
            get
            {
                return PerimetrCalc();
            }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalc()
        {
            double S = side1 * side2;
            return S;
        }

        public double PerimetrCalc()
        {
            double P = 2 * (side1 + side2);
            return P;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.Write("Введите первую сторону прямоугольника: ");
            s1 = Console.ReadLine();
            Console.Write("Введите вторую сторону прямоугольника: ");
            s2 = Console.ReadLine();

            Rectangle R = new Rectangle(Convert.ToDouble(s1), Convert.ToDouble(s2));
            Console.WriteLine("Площадь прямоугольника равна: " + R.Area);
            Console.WriteLine("Периметр прямоугольника равен: " + R.Perimetr);


            Console.ReadKey();
        }
    }
}
