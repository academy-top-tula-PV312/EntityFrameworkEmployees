using EFInheritanceApp;

// Inheritance -
// TPH - Table Per Hierarhy
// TPT - Table Per Type

//await Examples.InheritanceInitExample();

using (EmployeeAppContext context = new())
{
    var employees = context.Employees;
    var managers = context.Managers;
    var developers = context.Developers;

    Console.WriteLine($"\nEmployees:");
    foreach (var item in employees)
        Console.WriteLine($"\t{item.Name}\t{item.Age}\t{item.Salary}");

    Console.WriteLine($"\nManagers:");
    foreach (var item in managers)
        Console.WriteLine($"\t{item.Name}\t{item.Age}\t{item.Salary}\t{item.Rate}");

    Console.WriteLine($"\nDevelopers:");
    foreach (var item in developers)
        Console.WriteLine($"\t{item.Name}\t{item.Age}\t{item.Salary}\t{item.Bonus}");
}



