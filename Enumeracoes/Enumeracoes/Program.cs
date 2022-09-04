using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //convertendo enum para string
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //convertendo string para enum
            
            Console.WriteLine();
            Console.WriteLine(txt);
            Console.WriteLine(os);

            

        }
    }
}

/*Enumerações:
    - é um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas
    - Palavra chave em C# -> enum (tipo valor)
    - vantagem -> melhor semântica, código mais legível e auxiliado pelo compilador (não aceita valor fora do determinado previamente)
 */


/*Exemplo: <diagram máquina de estados>
    - Ciclo de vida de um pedido:
        =======================
       |    Pending Payment    |
        =======================
            
                Billing

        =======================
       |      Processing       |
        =======================

                Dispatch

        =======================
       |        Shipped        |
        =======================

                Deliver

        =======================
       |        Delivered      |
        =======================
 */


/*
    - Categorias de Classes:
    - em um sistema orientado a objetos, de modo geral "tudo é objeto";
    - Por questões de design tais como organização, flexibilidade, reuso, delegação, etc., há várias categorias de classes:

    -> Views = telas do sistema;
    -> Controllers = meio de campo entre a tela e o sistema;
    -> Entities = entidades de negócio (produtos, clientes, etc.);
    -> Services = autenticação, serviços de e-mail, etc.;
    -> Repositories = classes responsáveis por acessar o repositório de dados;

 */

/*
    Composição:
        - é um tipo de associação que permite que um objeto contenha outro
        - relação -> "tem-um" ou "tem-vários"
        - Vantagens:
            - Organização -> divisão de responsabilidades
            - Coesão
            - Flexibilidade
            - Reuso

        - Nota: embora o símbolo UML para composição (todo-parte) seja o diamante
                preto, neste contexto estamos chamando de composição qualquer associação
                tipo "tem-um" e "tem-vários".
 */




