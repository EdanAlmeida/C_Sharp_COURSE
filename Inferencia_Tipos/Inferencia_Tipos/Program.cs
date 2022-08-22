using System;
using System.Globalization;

namespace Inferencia_Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTimeKind e padrão ISO8601
            //Armazenar em formato UTC (Greenwich Mean Time Zone) (texto: BD, Json, XML)
            //Instanciar e mostrar em formato local

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D1 Kind: " + d1.Kind);
            Console.WriteLine("D1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("D1 to Utc:  " + d1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("D2: " + d2);
            Console.WriteLine("D2 Kind: " + d2.Kind);
            Console.WriteLine("D2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("D2 to Utc:  " + d2.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("D3: " + d3);
            Console.WriteLine("D3 Kind: " + d3.Kind);
            Console.WriteLine("D3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("D3 to Utc:  " + d3.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("=================================================");

            /*Padrão ISO 8601
                - Formato -> yyyy-MM-ddTHH:mm:ssZ
                # Z -> Essa data está armazenada na forma de string no padrão Utc.
             */

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine(d4);
            Console.WriteLine("D4 Kind: " + d4.Kind);
            Console.WriteLine("D4 to Local: " + d4.ToLocalTime());
            Console.WriteLine("D4 to Utc:  " + d4.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine(d5); //A data instanciada já é formatada para o padrão do computador do usuário
            Console.WriteLine("D5 Kind: " + d5.Kind);
            Console.WriteLine("D5 to Local: " + d5.ToLocalTime());
            Console.WriteLine("D5 to Utc:  " + d5.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado! Não está no formato 'Universal' (fora da ISO 8601)
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

        }
    }
}


/*
            //Inferência de Tipos - VAR
            var x = 10;
            var y = 20.3;
            var z = "Edan";
            //O uso excessivo pode gerar diversos problemas
            //
 */


/*
             //Switch case
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                default:
                    day = "Invalid day";
                    break;
            }
 */

/*
            //Sintaxe alternativa - expressão condicional ternária
            double preco = 50.0;
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * .05;
            Console.WriteLine(desconto);
 */


/*
            //Funções interessantes para string
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();// <> ToLower
            string s2 = original.Trim(); //apaga os espaços em branco
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s3 = original.Substring(3);
            string s4 = original.Substring(3, 5);

            string s5 = original.Replace('a', 'x'); //Não precisa ser do mesmo tamanho

            bool b1 = String.IsNullOrEmpty(original); //testa se o conteúdo é nulo ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: - " + original + "-");
            Console.WriteLine("S1: - " + s1 + "-");
            Console.WriteLine("S2: - " + s2 + "-");
            Console.WriteLine("Index Of (bc): " + n1);
            Console.WriteLine("Last Index Of (bc): " + n2);
            Console.WriteLine("Substring(3): " + s3);
            Console.WriteLine("Substring(3, 5): " + s4);
            Console.WriteLine("Replace('a', 'x'): " + s5);
            Console.WriteLine();
            Console.WriteLine("Is Null or Empty: " + b1);
            Console.WriteLine("Is Null or White Space: " + b2);

            //Lembrando que string é imutável - se usar o mesmo nome de variável com outra atribuiçõa, irá apontar para outro endereço (heap)
            //Conversão de string para número e vice-versa (já utilizamos)
                // int.Parse(); x.ToString("F2"); etc.
 */



/*
            //DateTime Construtores
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //Quant. de Ticks desde o dia 1º de janeiro da era atual
            Console.WriteLine();

            //Builders - propriedades que instanciam um DateTime
            DateTime d2 = new DateTime(2022, 08, 22);
            DateTime d3 = new DateTime(2022, 08, 22, 09, 46, 03); //é possível colocar também o milisegundo, mas precisa de uma formatação específica

            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow; //Horário Greenwich Mean Time Zone (universal)

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Parse("2000-08-15"); //posso usar o formato brasileiro de datas
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");

            Console.WriteLine();
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            Console.WriteLine();
            DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d9 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d8);
            Console.WriteLine(d9);
 */

/*
            //TimeSpan -> intervalo entre dois instantes
            //armazena uma duração na forma de ticks (100 nanosegundos)
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine();
            TimeSpan t2 = new TimeSpan(); //TimeSpan com duração 0
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); // Dias, horas, minutos, segundos / é possível inserir os milisegundos

            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            Console.WriteLine();
            //Métodos From - usado para o cálculo de juros e multa
            TimeSpan t5 = TimeSpan.FromDays(1.5);

            Console.WriteLine(t5);
 */


/*
            //Propriedades e operações com DateTime
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine();
            Console.WriteLine("1) Date: " + d.Date); //extrai toda a data sem a hora
            Console.WriteLine("2) Day: " + d.Day); //extrai apenas o dia
            Console.WriteLine("3) Day of the Week: " + d.DayOfWeek); //várias opções de dados
            Console.WriteLine("4) Hour: " + d.Hour);
            Console.WriteLine("5) Kind: " + d.Kind);
            Console.WriteLine("6) Milisecond: " + d.Millisecond);
            Console.WriteLine("7) Minute: " + d.Minute);
            Console.WriteLine("8) Month: " + d.Month);
            Console.WriteLine("9) Ticks: " + d.Ticks);
            Console.WriteLine("10) Time of Day: " + d.TimeOfDay); //TimeSpan
            Console.WriteLine("11) Year: " + d.Year);
            Console.WriteLine("12) Day of Year: " + d.DayOfYear);

            Console.WriteLine();
            Console.WriteLine(d.ToLongDateString()); //converte o tipo DateTime para string <> ToShortDateString()

            string s1 = d.ToLongTimeString();
            Console.WriteLine(s1);

            //é possível usar a formatação ToString() - especificando

            Console.WriteLine();
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(30);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


            Console.WriteLine();
            DateTime d4 = new DateTime(2000, 10, 15);
            DateTime d5 = new DateTime(2000, 10, 18);

            TimeSpan t = d5.Subtract(d4);
            Console.WriteLine(t);

 */


/*
            //Propriedades com TimeSpan
            TimeSpan t1 = TimeSpan.MaxValue; //Min value é possível
            TimeSpan t2 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t1);
            Console.WriteLine(t2);

            Console.WriteLine("Days: " + t2.Days);
            Console.WriteLine("Hours: " + t2.Hours);
            Console.WriteLine("Ticks: " + t2.Ticks);

            Console.WriteLine();
            Console.WriteLine("TotalDays: " + t2.TotalDays); //devolve a fração em dias
            Console.WriteLine("TotalHours: " + t2.TotalHours);
            Console.WriteLine("TotalMinutes: " + t2.TotalMinutes);
            Console.WriteLine();

            //Operações com TimeSpan
            TimeSpan t3 = new TimeSpan(1, 30, 10);
            TimeSpan t4 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t3.Add(t4);
            TimeSpan dif = t3.Subtract(t4);
            TimeSpan mult = t4.Multiply(2.0);
            TimeSpan div = t3.Divide(2.0);

            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

 */
