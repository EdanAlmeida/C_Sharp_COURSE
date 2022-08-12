using System;
using System.Globalization;

namespace Classes_Atributos_Metodos_MembrosEstaticos
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }


        public bool Aprovado()
        {
            if(NotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.00;
            }
            else
            {
                return 60.00 - NotaFinal();
            }
        }
    

    }
}
