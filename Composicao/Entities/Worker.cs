using System;
using System.Collections.Generic;
using Composicao.Entities.Enums;

namespace Composicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Associação entre as classes Worker e Department 
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); 

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
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
            double sum = BaseSalary;
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
// Composição entre as classes Worker e HourContract
// Composição é um tipo de associação onde uma classe é composta por outra classe, ou seja,
// a classe composta é responsável pela criação e destruição da classe componente. No exemplo acima,
// a classe Worker é composta por uma lista de HourContract, o que significa que um trabalhador pode ter vários contratos de hora,
// e esses contratos são parte integrante do trabalhador.
// Se o trabalhador for destruído, os contratos de hora associados a ele também serão destruídos.
