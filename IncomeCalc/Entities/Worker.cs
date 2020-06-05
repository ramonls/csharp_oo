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

    }
}
