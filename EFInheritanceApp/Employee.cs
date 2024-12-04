using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFInheritanceApp
{
    //[Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public decimal Salary { get; set; }
    }

    //[Table("Managers")]
    public class Manager : Employee
    {
        public float Rate { get; set; }
    }

    //[Table("Developers")]
    public class Developer : Employee
    {
        public float Bonus { get; set; }
    }
}
