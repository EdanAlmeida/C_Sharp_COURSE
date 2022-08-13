using System;
using System.Globalization;

namespace Classes_Atributos_Metodos_MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício conversão de R$ para $ - utilizando Classe Utilitária:

            Console.Write("Qual é a cotação do dolar? ");
            double cotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorReais = ConversorDeMoeda.ConversorDolarIof(cotDolar, quantDolares);

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago: R$ " + valorReais.ToString("F2", CultureInfo.InvariantCulture));

           

        }
    }
}


/*
 Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas). 
Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
possui a maior área. A fórmula para calcular a área de um triângulo a partir das medidas de seus 
lados a, b e c é a seguinte (fórmula de Heron):

    area = Math.Sqrt(p (p - a)( p - b)( p - c)              onde p = (a + b + c) / 2
 */

/*
             //Resolução sem Programação Orientada a Objetos:
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triangulo 'X': ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo 'Y': ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area: 'X'");
            }
            else
            {
                Console.WriteLine("Maior Area: 'Y'");
            }

 */


/*
            //Resolução com Programação Orientada a Objetos
            Triangulo x, y; // criando as variáveis
            x = new Triangulo(); //instanciando a variável
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo 'X': ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo 'Y': ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area: 'X'");
            }
            else
            {
                Console.WriteLine("Maior Area: 'Y'");
            }

 */


/*
            //Problema Pessoa mais Velha
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda Pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome + " com " + p1.Idade + " anos.");
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome + " com " + p2.Idade + " anos.");
            }
*/

/*
 //Problema Salário Médio
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: R$");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: R$");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário médio: R$" + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
 */

/*
 //Resolução com Programação Orientada a Objetos - Método da área na classe (Triangulo)
            Triangulo x, y; // criando as variáveis
            x = new Triangulo(); //instanciando a variável
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo 'X': ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo 'Y': ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area: 'X'");
            }
            else
            {
                Console.WriteLine("Maior Area: 'Y'");
            }

 */

/*=====================================================================================*/

/*
 Fazer um programa para ler os dados de um produto em estoque (nome, preço e
quantidade no estoque). Em seguida:
• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
estoque)
• Realizar uma entrada no estoque e mostrar novamente os dados do produto
• Realizar uma saída no estoque e mostrar novamente os dados do produto
 */


/*
            //Problema Estoque
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: R$");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

 */

/*
             //Problema Retangulo
            Retangulo ret = new Retangulo();

            Console.WriteLine("Informe os dados do retangulo: ");
            Console.Write("Largura: ");
            ret.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            ret.h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do retangulo: ");
            Console.WriteLine(ret);
 */


/*
             // Problema Salário
             Funcionario f1 = new Funcionario();

            Console.WriteLine("Informe os Dados do Funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(f1);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double pctgm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(pctgm);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f1);
            */


/*
  //Problema Aluno/Nota
            Aluno student1 = new Aluno();
            Console.Write("Nome do Aluno: ");
            student1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            student1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA Final: " + student1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (student1.Aprovado())
            {
                Console.WriteLine("APROVADO! ");
            }
            else
            {
                Console.WriteLine("REPROVADO! \nFALTARAM " + student1.NotaRestante() + " PONTOS");
            }
 */


/*
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            //Membro estáticos - Resolução na própria classe do programa (static void Main(string[] args){}):

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia (double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
 
 */

/*
            //Membro estáticos - Resolução criando uma classe 'Calculadora' - instanciação de objeto:

            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double vol = calc.Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

 */


/*
           //Membro estáticos - Resolução criando uma classe 'Calculadora' - operações estáticas (sem objeto):
           //FAz muito mais sentido, dado que as operações independem da criação de um objeto para instanciação

           Console.Write("Entre o valor do raio: ");
           double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           double circ = Calculadora.Circunferencia(raio);
           double vol = Calculadora.Volume(raio);

           Console.WriteLine();
           Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
           Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
           Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
           
 */

