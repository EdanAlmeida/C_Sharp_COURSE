using System;
using System.Collections.Generic;
using System.Text;

namespace Comportamento_Memoria_Arrays_Listas
{
    struct Point
    {
        //Definição de um 'ponto' no plano 2D
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }

    }
}
