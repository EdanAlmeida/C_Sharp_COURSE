using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}


/*            sbyte x = 100;
            Console.WriteLine(x);
            long n4 = 2147483648L; //long int
            Console.WriteLine(n4);

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';

            float n5 = 4.5f;
            double n6 = 4.5;

            string nome = "Maria Green"; /*cadeia de caracteres unicode imutável
                                         (segurança, simplicidade, thread safe)*/

/*object obj1 = "Alex Brown"; //Toda classe em C# é subclasse de object
object obj2 = 4.5f;

Console.WriteLine(completo);
Console.WriteLine(genero);
Console.WriteLine(letra);
Console.WriteLine(n5);
Console.WriteLine(n6);
Console.WriteLine(nome);
Console.WriteLine(obj1);
Console.WriteLine(obj2);

//valore máximo e mínimo
int value1 = int.MinValue;
int value2 = int.MaxValue;
sbyte value3 = sbyte.MinValue;
decimal value4 = decimal.MaxValue;

Console.WriteLine(value1);
Console.WriteLine(value2);
Console.WriteLine(value3);
Console.WriteLine(value4); */


/*            Console.WriteLine("Bom dia!"); //imprime e quebra a linha
            Console.Write("Boa tarde!"); // imprime e NÃO quebra linha
            Console.WriteLine("============================================");

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture)); 
                                                   //para imprimir com ponto ao invés de vírgula*/

/*int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem  saldo igual a {2:F2} reais", nome, idade, saldo);
            //placeholder

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R$ {saldo:F2}");
            //interpolação

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture));
            //somente com concatenação é possível mudar para ponto o separador
            //concatenação

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);

            int a = 10;
            a++;
            Console.WriteLine(a);

            int b = a++; //primeiro atribui o valor de 'a' em 'b' e, depois, incrementa o 'a'
            Console.WriteLine(b);

            b = ++a; //incrementa o 'a' e, depois, atribui 'a' ao 'b'
            Console.WriteLine(b);*/


/*            //Conversão implícita e Casting
            //implícita -> conteúdo de um tipo atribuído naturalmente a variável de outro tipo
            //casting -> conversão explícita entre tipos compatíveis.

            float x = 4.5f; //4 bytes
            double y = x; //8 bytes -> 4 bytes cabe dentro de 8
            Console.WriteLine(y); //conversão i´mplícita

            double a = 5.1;
            float b = (float)a; //8 bytes não cabem em 4 bytes. Pode ocasionar em perda de dados.
            Console.WriteLine(b);

            int c = (int)a;
            Console.WriteLine(c); //perda de informação - valor truncado

            int d = 5;
            int e = 2;

            double resultado = (double) d / e; //expressão somente considerando valores inteiros
            Console.WriteLine(resultado);*/

/* int x = 17;
            int y = 3;
            int resto = x % y;
            Console.WriteLine(resto);

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);*/


/*//Entrada de dados:
string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

Console.WriteLine("Voce digitou: ");
Console.WriteLine(frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

//split -> separar por espaço
string[] vet = Console.ReadLine().Split(' ');
string p1 = vet[0];
string p2 = vet[1];
string p3 = vet[2];

Console.Write(p1);
Console.Write(p2);
Console.Write(p3);*/
