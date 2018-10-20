using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCalculadora
{
    class LogicaCalculadora
    {
        public double? PerimetroTriangulo(double a, double b, double c)
        {
            if (validarTriangulo(a, b, c))
            {
                double perimetro = a + b + c;
                return perimetro;
            }
            else
            {
                return null;
            }
        }

        public double? AreaTriangulo(double a, double b, double c)
        {
            if (validarTriangulo(a, b, c))
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return area;
            }
            else
            {
                return null;
            }
        }

        public bool validarTriangulo(double a, double b, double c)
        {
            double mayor = a;
            mayor = (b > mayor) ? b : mayor;
            mayor = (c > mayor) ? c : mayor;
            double sumaMenores = a + b + c - mayor;
            if (sumaMenores > mayor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
