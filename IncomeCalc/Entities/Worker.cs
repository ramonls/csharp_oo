using IncomeCalc.Entities.Enums;
using System;
using System.Collections.Generic;

namespace IncomeCalc.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } //Associação entre duas classes
        // Como vamos associar a classe HourContract e ela poder ter 1 ou máis, vamos criar em uma lista,
        // vamos instanciar para ela não ser nula
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //construtor padrão
        public Worker()
        {

        }
        /*Construtor passando parâmetros
          Sempre quando tivermos uma associação para muitos não é usuál passar uma lista instanciada em um construtor do objeto.
          Essa lista comerá vazia e depois irá adicionando elementos conforme a necessidade.
          SEMPRE QUE TIVER UMA ASSOCIAÇÃO PARA MUITOS, ELA NÃO SERÁ INCLUSA NO CONSTRUTOR!!!        
         */
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary; // Ele recebe o BaseSalary, pq é o minimo que ele irá ganhar.

            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}
