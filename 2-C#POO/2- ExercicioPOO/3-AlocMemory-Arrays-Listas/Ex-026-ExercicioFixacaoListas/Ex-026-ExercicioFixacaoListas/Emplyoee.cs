using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_026_ExercicioFixacaoListas
{
    public class Emplyoee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void salary(double UpSalary)
        {
            Salary += Salary * (UpSalary / 100.0);
        }

        public void Register(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"-> Id:{Id} \n-> Name:{Name} \n-> Salary:{Salary}\n ---------------------\n";
        }
    }
    
}

