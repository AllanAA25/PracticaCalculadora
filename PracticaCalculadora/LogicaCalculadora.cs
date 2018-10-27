using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCalculadora
{
    class LogicaCalculadora
    {
        public double? CalcularArea(string text1, string text2, string text3, string text4, string text5, string figura)
        {
            EnumFiguras figurax = SeleccionFigura(figura);

            double? resultado;

            switch (figurax)
            {
                case EnumFiguras.Triangulo:
                    resultado = AreaTriangulo(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.Cuadrado:
                    resultado = AreaCuadrado(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.Rectangulo:
                    resultado = AreaRectangulo(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.Rombo:
                    resultado = AreaRombo(text1, text2, text3, text4, text5);
                    return resultado;
            }
            return null;
        }


        public double? CalcularPerimetro(string text1, string text2, string text3, string text4, string text5, string figura)
        {
            EnumFiguras figurax = SeleccionFigura(figura);

            double? resultado;

            switch (figurax)
            {
                case EnumFiguras.Triangulo:
                    resultado = PerimetroTriangulo(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.Cuadrado:
                    resultado = PerimetroCuadrado(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.Rectangulo:
                    resultado = PerimetroRectangulo(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.Rombo:
                    resultado = PerimetroRombo(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.PoligonoReg:
                    resultado = PerimetroPoligonoRegular(text1, text2, text3, text4, text5);
                    return resultado;
            }
            return null;
        }

        public double? CalcularVolumen(string text1, string text2, string text3, string text4, string text5, string figura)
        {
            EnumFiguras figurax = SeleccionFigura(figura);

            double? resultado;

            switch (figurax)
            {
                case EnumFiguras.Triangulo:
                    resultado = PerimetroTriangulo(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.Cuadrado:
                    resultado = PerimetroCuadrado(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.Rectangulo:
                    resultado = AreaRectangulo(text1, text2, text3, text4, text5);
                    return resultado;
                case EnumFiguras.Rombo:
                    resultado = AreaRombo(text1, text2, text3, text4, text5);
                    return resultado;
            }
            return null;
        }

        /// <summary>
        /// Calcula el perímetro de un triángulo válido.
        /// </summary>
        /// <param name="a">Lado a</param>
        /// <param name="b">Lado b</param>
        /// <param name="c">Lado c</param>
        /// <returns>Perímetro</returns>
        public double PerimetroTriangulo(double a, double b, double c)
        {
                double perimetro = a + b + c;
                return perimetro;
        }
        public double? PerimetroTriangulo(string text1, string text2, string text3, string text4, string text5)
        {
            double a = Double.Parse(text1);
            double b = Double.Parse(text2);
            double c = Double.Parse(text3);

            if (ValidarTriangulo(a, b, c))
            {
                return PerimetroTriangulo(a, b, c);
            }
            else return null;
        }

        /// <summary>
        /// Calcula el área de un triángulo válido.
        /// </summary>
        /// <param name="a">Lado a</param>
        /// <param name="b">Lado b</param>
        /// <param name="c">Lado c</param>
        /// <returns>Área</returns>
        public double AreaTriangulo(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public double? AreaTriangulo(string text1, string text2, string text3, string text4, string text5)
        {
            double a = Double.Parse(text1);
            double b = Double.Parse(text2);
            double c = Double.Parse(text3);

            if (ValidarTriangulo(a, b, c))
            {
                return AreaTriangulo(a, b, c);
            }
            else return null;
        }

        /// <summary>
        /// Calcula el perímetro de un cuadrado válido.
        /// </summary>
        /// <param name="l">Lado</param>
        /// <returns>Perímetro</returns>
        public double PerimetroCuadrado(double l)
        {
            double perimetro = l * 4;
            return perimetro;
        }

        public double? PerimetroCuadrado(string text1, string text2, string text3, string text4, string text5)
        {
            double a = Double.Parse(text1);

            if (a > 0)
            {
                return PerimetroCuadrado(a);
            }
            else return null;
        }

        /// <summary>
        /// Calcula el área de un cuadrado válido.
        /// </summary>
        /// <param name="l">Lado</param>
        /// <returns>Área</returns>
        public double AreaCuadrado(double l)
        {
            double area = l * l;
            return area;
        }

        public double? AreaCuadrado(string text1, string text2, string text3, string text4, string text5)
        {
            double a = Double.Parse(text1);

            if (a>0)
            {
                return AreaCuadrado(a);
            }
            else return null;
        }

        /// <summary>
        /// Calcula el perímetro de un rectangulo válido.
        /// </summary>
        /// <param name="a">Ancho</param>
        /// <param name="l">Largo</param>
        /// <returns>Perímetro</returns>
        public double PerimetroRectangulo(double a, double l)
        {
            double perimetro = (a + l) * 2;
            return perimetro;
        }

        public double? PerimetroRectangulo(string text1, string text2, string text3, string text4, string text5)
        {
            double a = Double.Parse(text1);
            double b = Double.Parse(text2);

            if (a > 0 && b > 0)
            {
                return PerimetroRectangulo(a, b);
            }
            else return null;
        }

        /// <summary>
        /// Calcula el área de un rectangulo válido.
        /// </summary>
        /// <param name="a">Ancho</param>
        /// <param name="l">Largo</param>
        /// <returns>Área</returns>
        public double AreaRectangulo(double a, double l)
        {
            double area = a * l;
            return area;
        }

        public double? AreaRectangulo(string text1, string text2, string text3, string text4, string text5)
        {
            double a = Double.Parse(text1);
            double b = Double.Parse(text2);

            if (a > 0 && b >0)
            {
                return AreaRectangulo(a, b);
            }
            else return null;
        }


        /// <summary>
        /// Calcula el perímetro de un rombo válido.
        /// </summary>
        /// <param name="dMayor">Diagonal mayor</param>
        /// <param name="dMenor">Diagonal menor</param>
        /// <returns>Perímetro</returns>
        public double PerimetroRombo(double dMayor, double dMenor)
        {
            double perimetro = 2 * Math.Sqrt(Math.Pow(dMayor, 2) + Math.Pow(dMenor, 2));
            return perimetro;
        }
        public double? PerimetroRombo(string text1, string text2, string text3, string text4, string text5)
        {
            double a = Double.Parse(text1);
            double b = Double.Parse(text2);

            if (a > 0 && b > 0)
            {
                return PerimetroRombo(a, b);
            }
            else return null;
        }

        /// <summary>
        /// Calcula el área de un rombo válido.
        /// </summary>
        /// <param name="dMayor">Diagonal mayor</param>
        /// <param name="dMenor">Diagonal menor</param>
        /// <returns>Área</returns>
        public double AreaRombo(double dMayor, double dMenor)
        {
            double area = (dMayor * dMenor) / 2;
            return area;
        }

        public double? AreaRombo(string text1, string text2, string text3, string text4, string text5)
        {
            double a = Double.Parse(text1);
            double b = Double.Parse(text2);

            if (a > 0 && b > 0)
            {
                return AreaRombo(a, b);
            }
            else return null;
        }

        public double PerimetroPoligonoRegular(double a)
        {
                double perimetro = a*5;
                return perimetro;
        }

        public double? PerimetroPoligonoRegular(string text1, string text2, string text3, string text4, string text5)
        {
            double a = Double.Parse(text1);

            if (a > 0)
            {
                return PerimetroPoligonoRegular(a);
            }
            else return null;
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

        private EnumFiguras SeleccionFigura(string figura)
        {
            EnumFiguras resultado = EnumFiguras.Triangulo;
            switch(figura)
            {
                case "Triángulo":
                    resultado = EnumFiguras.Triangulo;
                    return resultado;

                case "Cuadrado":
                    resultado = EnumFiguras.Cuadrado;
                    return resultado;

                case "Rectangulo":
                    resultado = EnumFiguras.Rectangulo;
                    return resultado;

                case "Rombo":
                    resultado = EnumFiguras.Rombo;
                    return resultado;

                case "Polígono":
                    resultado = EnumFiguras.PoligonoReg;
                    return resultado;

                case "Trapecio":
                    resultado = EnumFiguras.Trapecio;
                    return resultado;

                case "Romboide":
                    resultado = EnumFiguras.Romboide;
                    return resultado;

                case "Cilindro":
                    resultado = EnumFiguras.Cilindro;
                    return resultado;
                case "Esfera":
                    resultado = EnumFiguras.Esfera;
                    return resultado;
                case "Cono":
                    resultado = EnumFiguras.Cono;
                    return resultado;
                case "Cubo":
                    resultado = EnumFiguras.Cubo;
                    return resultado;
                case "Prisma":
                    resultado = EnumFiguras.Prisma;
                    return resultado;
                case "Piramide Cuadrada":
                    resultado = EnumFiguras.PiramideCuadr;
                    return resultado;
                case "Piramide Poligonal":
                    resultado = EnumFiguras.PiramidePolig;
                    return resultado;
            }
            return resultado;

        }


    }
}
