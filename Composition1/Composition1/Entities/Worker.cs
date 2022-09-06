using System.Collections.Generic;
using Composition1.Entities.Enums;

namespace Composition1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } //ligado ao enum WrkerLevel
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //composição para ligar os objetos trabalhador + departamento
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //instanciada evitar que seja nula
        //respeitando o nome do diagrama
        //usamos lista pq pode ter + de 1 contrato

        public Worker()
            //construtor padrão
        {
        }

        //Sempre que tiver associação para muitos, não incluir no construtor
        public Worker(string nome, WorkerLevel level, double baseSalary, Department department)
            //construtor com os atributos
        {
            Name = nome;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Quando se tem uma lista, usa-se os métodos de adicionar e remover na elementos
        public void AddContract(HourContract contract)
            //adiciona na lista o contrato que vai entrar como parâmetro
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
            //remove da lista um contrato que vai entrar como parâmetro
        {
            Contracts.Remove(contract);
        }

        //Percorrendo a lista e checando as datas e valores
        public double Income(int year, int month)
        {
            double sum = BaseSalary; //o trabalhador já tem o salário base
            //percorre a lista e compara se os valores atendem aos parâmetros passados
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}

//Composição -> objetos associados entre si
