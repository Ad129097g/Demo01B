using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Triángulo
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public int x1 { get; set; }
        public int y1 { get; set; }

        public int x2 { get; set; }
        public int y2 { get; set; } 

        public int x3 { get; set; }
        public int y3 { get; set; }

        private double CalcularDistancia(int a1, int b1, int a2, int b2)
        {
            return Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
        }

        public void CalcularLados()
        {
            a = CalcularDistancia(x1, y1, x2, y2); 
            b = CalcularDistancia(x2, y2, x3, y3); 
            c = CalcularDistancia(x3, y3, x1, y1); 
        }

        public double Semiperimetro()
        {
            return (a + b + c) / 2;
        }
        public double CalcularArea()
        {
            return Math.Sqrt(Semiperimetro() * (Semiperimetro() - a) * (Semiperimetro() - b) * (Semiperimetro() - c));
        }
        public double CalcularPerimetro()
        {
            return Semiperimetro() * 2;
        }


    }
}
