using System;
using System.Globalization;

namespace Classes_Atributos_Metodos_MembrosEstaticos
{
    class Retangulo
    {
        public double b;
        public double h;


        public double Area()
        {
            return b * h;
            
        }


        public double Perimetro()
        {
            return (b * 2) + (h * 2);
        }


        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
        }


        public override string ToString()
        {
            return "Area: "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\n" 
                + "Perimetro: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "Diagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
