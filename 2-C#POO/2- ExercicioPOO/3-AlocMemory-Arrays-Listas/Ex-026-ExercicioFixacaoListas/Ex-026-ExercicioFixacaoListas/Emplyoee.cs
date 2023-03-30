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

        public double salary(double UpSalary)
        {
            return Salary * (UpSalary / 100);
        }

        public void Register(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Subs(List<Emplyoee> empoyeerList, int SelectId, double UpSalary)
        {
            empoyeerList[SelectId] = UpSalary;
        }

        public override string ToString()
        {
            return $"-> Id:{Id} \n-> Name:{Name} \n-> Salary:{Salary}\n ---------------------\n";
        }
    }
    
}

