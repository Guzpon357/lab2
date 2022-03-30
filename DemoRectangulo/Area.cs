using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    internal class Area
    {

        public double x1 { get; set; }
        public double y1 { get; set; }

        public double x2 { get; set; }
        public double y2 { get; set; }

        public double x3 { get; set; }
        public double y3 { get; set; }

        public double x4 { get; set; }
        public double y4 { get; set; }


        public double calcularArea(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double area = Math.Abs((x1 * y2 + x2 * y3 + x3 * y4 + x4 * y1) - (x1 * y4 + x4 * y3 + x3 * y2 + x2 * y1));
            return (area / 2);
        }
        public double D1(double x1, double y1, double x2, double y2)
        {
            double d1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return d1;
        }
        public double D2(double x3, double y3, double x2, double y2)
        {
            double d2 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            return d2;
        }
        public double D3(double x3, double y3, double x4, double y4)
        {
            double d3 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            return d3;
        }
        public double D4(double x1, double y1, double x4, double y4)
        {
            double d4 = Math.Sqrt(Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2));
            return d4;
        }

        public double calcularPerimetro(double d1, double d2, double d3, double d4)
        {
            double perimetro = d1 + d2 + d2 + d4;
            return perimetro;
        }
    }
}
