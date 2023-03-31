using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_026_ExercicioFixacaoListas
{
    internal class DataInput
    {
        public void input()
        {
            List<Emplyoee> empoyeerList = new List<Emplyoee>(); //List

            Console.WriteLine("=======================================");
            Console.WriteLine("  R E G I S T E R  - E M P L O Y O E E ");
            Console.WriteLine("=======================================");

            Console.Write("Do you is in th program. Do you wish to continue? ( Y / N ): ");
            char Select = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine();
            Console.Clear();
            
            if (Select == 'N')
            {
                Console.Clear();
                Console.Write("Thanks! ");
                Console.ReadKey();
            }
            else if (Select != 'Y' && Select != 'N')
            {
                Console.Clear();
                Console.Write("Error! Write one string valid.");
                Console.ReadKey();
            }
            else
            {
                Console.Write("How many employee will be registered? ");
                int Qnt = int.Parse(Console.ReadLine());
                             
                for (int i = 1; i <= Qnt ; i++)
                {
                    Emplyoee obj = new Emplyoee(); // obj
                    Console.Clear();

                    Console.Write("Write the ID: ");
                    int id = int.Parse(Console.ReadLine());
                    if (id > 0 && id <= 100)
                    {
                        Console.Write("Write the name for employee: ");
                        string nome = Console.ReadLine();

                        Console.Write("Write the salary: ");
                        double salary = double.Parse(Console.ReadLine());

                        obj.Register(id, nome, salary);
                        empoyeerList.Add(obj);

                        Console.WriteLine();

                        Console.WriteLine("Press [ENTER] for continue...");
                        Console.Write("");
                        
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                    }
                    else if (id < 1 || id > 100)
                    {
                        Console.Clear();
                        Console.WriteLine("Erro! ID only between in range: 1 and 100!");
                    }
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine("Erro! Write valid ID! ");
                    }
                }

                foreach (var l in empoyeerList)
                {
                    Console.WriteLine(l);
                }

                Console.Write("Want to increase salary for employee?  { Y / N }: ");
                char increase = char.Parse(Console.ReadLine());

                if (increase == 'Y' || increase == 'y')
                {
                    Console.Clear();
                    Console.Write("Enter the employee ID that will have salary increase: ");
                    int selectId = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    List<int> idEmployeeList = empoyeerList.Select(x => x.Id).ToList();

                    if (idEmployeeList.Contains(selectId))
                    {
                        Console.Write("Write the '%' for salary increase amount: ");
                        int UpSalary = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine();
                        Console.Write("Waiting for update ");

                        for (int i = 1; i <= 3; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }

                        Console.WriteLine();
                        Console.Write("Press [ENTER] to view the salary ... ");
                        Console.WriteLine();
                        Console.ReadKey();

                        foreach (Emplyoee employee in empoyeerList)
                        {
                            employee.salary(UpSalary);
                            Console.WriteLine("{0}: R${1}", employee.Name, employee.Salary);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Sorry! user not found.");
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Thansk for consulte!");
                    Console.ReadKey();
                }
            }
        }
    }
}
