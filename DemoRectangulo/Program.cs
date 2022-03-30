using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                double x1;
                double y1;

                double x2;
                double y2;

                double x3;
                double y3;

                double x4;
                double y4;

                Console.WriteLine("INGRESO DE COORDENADAS");
                Rectangulo rec = new Rectangulo();
 
                Console.WriteLine("Ingresar coordenada x1:");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar coordenada y1:");
                y1 = Convert.ToInt32(Console.ReadLine());

                rec.p1.x = x1;
                rec.p1.y = y1;


                Console.WriteLine("Ingresar coordenada x2:");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar coordenada y2:");
                y2 = Convert.ToInt32(Console.ReadLine());

                rec.p2.x = x2;
                rec.p2.y = y2;


                Console.WriteLine("Ingresar coordenada x3:");
                x3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar coordenada y3:");
                y3 = Convert.ToInt32(Console.ReadLine());

                rec.p3.x = x3;
                rec.p3.y = y3;


                Console.WriteLine("Ingresar coordenada x4:");
                x4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar coordenada y4:");
                y4 = Convert.ToInt32(Console.ReadLine());

                rec.p4.x = x4;
                rec.p4.y = y4;


                Area a = new Area();
                
                double area = a.calcularArea(x1,y1,x2,y2,x3,y3,x4,y4); 
                Console.WriteLine("El valor del area es: ", area);
                double area2 = rec.calcularArea(rec.p1, rec.p2, rec.p3, rec.p4);
                Console.WriteLine("El calor del area es: ", area2);
                
                double d1 = a.D1(x1, y1, x2, y2);
                double d2 = a.D1(x2, y2, x3, y3);
                double d3 = a.D1(x3, y3, x4, y4);
                double d4 = a.D1(x4, y4, x1, y1);
                double perimetro = a.calcularPerimetro(d1, d2, d3, d4);
                Console.WriteLine("El valor del perimetro es: ",perimetro);

            }
            catch (Exception e)
            {

                throw e;
            }
            
            
            

            Console.Read();

        }
    }
}
