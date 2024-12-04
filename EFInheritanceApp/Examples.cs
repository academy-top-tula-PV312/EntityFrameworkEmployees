using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritanceApp
{
    static public class Examples
    {
        public static async Task InheritanceInitExample()
        {
            using (EmployeeAppContext context = new())
            {
                await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();

                List<Employee> employees = new List<Employee>()
                {
                    new Employee(){ Name = "Sammy", Age = 29, Salary = 120000 },
                    new Employee(){ Name = "Jimmy", Age = 31, Salary = 95000 },
                };

                            List<Manager> managers = new List<Manager>()
                {
                    new Manager(){ Name = "Poppy", Age = 25, Salary = 110000, Rate = 1.2f },
                    new Manager(){ Name = "Lenny", Age = 36, Salary = 160000, Rate = 1.15f }
                };

                            List<Developer> developers = new List<Developer>()
                {
                    new Developer(){ Name = "Rikky", Age = 22, Salary = 210000, Bonus = 1.5f },
                    new Developer(){ Name = "Tommy", Age = 42, Salary = 290000, Bonus = 1.8f },
                };

                context.Employees.AddRange(employees);
                context.Managers.AddRange(managers);
                context.Developers.AddRange(developers);

                await context.SaveChangesAsync();
            }
        }
    }
}
