using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_026_ExercicioFixacaoListas
{
    internal class Emplyoee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private double Salary { get; set; }
        
        public void Register(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"->Id {Id} \n-> Name: {Name} \n-> Salary: {Salary}";
        }
    }
    
}

