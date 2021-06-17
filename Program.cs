using System;
using System.Collections.Generic;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            List<Employee> _employees = new List<Employee>();
         
            int number;
            bool success;
            string quit;

            do
            {
                Console.Clear();

                Console.WriteLine("Förnamn: ");
                employee.Firstname = Console.ReadLine();
                Console.WriteLine("Efternamn: ");
                employee.Lastname = Console.ReadLine();
                Console.WriteLine("Lön: ");
                success = int.TryParse(Console.ReadLine(), out number);
                if (success)
                {
                    employee.Salary = number;
                }
                else
                {
                    Console.WriteLine("Lön måste anges i heltal ");
                }

                _employees.Add(new Employee { Firstname = employee.Firstname, Lastname = employee.Lastname, Salary = employee.Salary });

                Console.Write("********************************************************");


                foreach (Employee employee2 in _employees)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Namn: {employee2.Firstname} Efternamn: {employee2.Lastname} Lön: {employee2.Salary}");
                }

                Console.WriteLine();
                Console.WriteLine("Vill du mata in fler tryck valfri tangent annars tryck q");
                ConsoleKeyInfo info = Console.ReadKey();
                quit = info.KeyChar.ToString();
                if (quit == "q")
                {
                    break;    
                };

            } while (quit != "q");
         

        }

    }
}

