using System;

namespace Composition1.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //construtor padrão
        public HourContract()
        {
        }

        //construtor com os parâmetros
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
            //retorna o valor total das horas trabalhadas * o valor por hora de trabalho do contrato
        {
            return ValuePerHour * Hours;
        }

    }
}
