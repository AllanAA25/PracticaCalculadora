using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCalculadora
{
    class LogicaCalculadora
    {
        /// <summary>
        /// Calcula el perímetro de un triángulo válido.
        /// </summary>
        /// <param name="a">Lado a</param>
        /// <param name="b">Lado b</param>
        /// <param name="c">Lado c</param>
        /// <returns>Perímetro del triángulo</returns>
        public double PerimetroTriangulo(double a, double b, double c)
        {
                double perimetro = a + b + c;
                return perimetro;
        }

        /// <summary>
        /// Calcula el área de un triángulo válido.
        /// </summary>
        /// <param name="a">Lado a</param>
        /// <param name="b">Lado b</param>
        /// <param name="c">Lado c</param>
        /// <returns>Área del triángulo</returns>
        public double AreaTriangulo(double a, double b, double c)
        {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return area;
        }

        public double PerimetroCuadrado(double l)
        {
                double perimetro = l * 4;
                return perimetro;
        }

        public double AreaCuadrado(double l)
        {
                double area = l * l;
                return area;
        }

        public double PerimetroRectangulo(double a, double l)
        {
                double perimetro = (a + l) * 2;
                return perimetro;
        }

        public double AreaRectangulo(double a, double l)
        {
                double perimetro = a * l;
                return perimetro;
        }

        public double PerimetroRombo(double dMayor, double dMenor)
        {
                double perimetro = 2 * Math.Sqrt(Math.Pow(dMayor, 2) + Math.Pow(dMenor, 2));
                return perimetro;
        }

        public double AreaRombo(double dMayor, double dMenor)
        {
                double area = (dMayor*dMenor)/2;
                return area;
        }

        public double PerimetroPoligonoRegular(int cantidadLados, double l)
        {
                double perimetro = cantidadLados * l;
                return perimetro;
        }

        public double AreaPoligonoRegular(int cantidadLados, double l, double a)
        {
            double area = (cantidadLados * l * a) / 2;
            return area;
        }

        public double PerimetroTrapecio(double a, double b, double c, double d)
        {
            double perimetro = a + b + c + d;
            return perimetro;
        }

        public double AreaTrapecio(double bMenor, double bMayor, double h)
        {
            double area = h * ((bMayor + bMenor) / 2);
            return area;
        }

        public double PerimetroRomboide(double a, double b)
        {
            double perimetro = 2 * (a + b);
            return perimetro;
        }

        public double AreaRomboide(double b, double h)
        {
            double area = b * h;
            return area;
        }

        public double VolumenCilindro(double r, double h)
        {
            double volumen = Math.PI * Math.Pow(r, 2) * h;
            return volumen;
        }

        public double VolumenEsfera(double r)
        {
            double volumen = (4 / 3) * Math.PI * Math.Pow(r, 3);
            return volumen;
        }

        public double VolumenCono(double r, double h)
        {
            double volumen = (1 / 3) * Math.PI * Math.Pow(r, 2) * h;
            return volumen;
        }

        public double VolumenCubo(double a)
        {
            double volumen = Math.Pow(a, 3);
            return volumen;
        }

        public double VolumenPrisma(double l, double a, double h)
        {
            double volumen = l * a * h;
            return volumen;
        }

        public double VolumenPiramideCuadrada(double lb, double h)
        {
            double volumen = (1 / 3) * Math.Pow(lb, 2) * h;
            return volumen;
        }

        public double VolumenPiramidePoligonal(int cantidadLados, double l, double a, double h)
        {
            double volumen = (1 / 3) * AreaPoligonoRegular(cantidadLados, l, a) * h;
            return volumen;
        }

        private bool ValidarTriangulo(double a, double b, double c)
        {
            if (EsPositivo(a) && EsPositivo(b) && EsPositivo(c))
            {
                double mayor = a;
                mayor = (b > mayor) ? b : mayor;
                mayor = (c > mayor) ? c : mayor;
                double sumaMenores = a + b + c - mayor;
                bool validacion = sumaMenores > mayor;
                return validacion;
            }
            else
            {
                return false;
            }
        }

        private bool EsPositivo(double x)
        {
            return x >= 0;
        }

    }
}
