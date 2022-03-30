using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    public class Rectangulo
    {
        public Punto p1 { get; set; }
        public Punto p2 { get; set; }
        public Punto p3 { get; set; }
        
        public Punto p4 { get; set; }

        public double calcularArea(Punto p1, Punto p2, Punto p3, Punto p4)
        {
            double area = Math.Abs((p1.x * p2.y + p2.x * p3.y + p3.x * p4.y + p4.x * p1.y) - (p1.x * p4.y + p4.x * p3.y + p3.x * p2.y + p2.x * p1.y));
            return (area / 2);
        }

        public double Perimetro()
        {
            return 0;
        }
    }
}
