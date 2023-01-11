using Prototype._2.Concrete_Prototype;

Console.Title = "Prototype";
#region Shallow Copy
//var manager = new Manager("Cindy");
//var managerClone = (Manager)manager.Clone();
//Console.WriteLine($"Manager was cloned: {managerClone.Name}");

//var employee = new Employee("Mohamed", managerClone);
//var employeeClone = (Employee)employee.Clone();
//Console.WriteLine($"Employee was cloned: {employeeClone.Name}," +
//    $"with manager {employeeClone.manager.Name}");

////change manager name
//managerClone.Name = "Karen"; 
//Console.WriteLine($"Employee was cloned: {employeeClone.Name}," +
//    $"with manager {employeeClone.manager.Name}");
#endregion

#region Deep Copy
var manager = new Manager("Cindy");
var managerClone = (Manager)manager.Clone();
Console.WriteLine($"Manager was cloned: {managerClone.Name}");

var employee = new Employee("Mohamed", managerClone);
var employeeClone = (Employee)employee.Clone(true);
Console.WriteLine($"Employee was cloned: {employeeClone.Name}," +
    $"with manager {employeeClone.manager.Name}");

//change manager name
managerClone.Name = "Karen";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}," +
    $"with manager {employeeClone.manager.Name}");
#endregion