using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Atributos_Metodos_MembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double ConversorDolarIof(double dolarValor, double quantDolar)
        {
            return (dolarValor * quantDolar) * (106.00 / 100.00);
        }
    }
}
