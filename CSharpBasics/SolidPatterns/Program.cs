using SolidPatterns;
using static SolidPatterns.DependencyInversionPrinciple;
using Human = SolidPatterns.DependencyInversionPrinciple.Human;
using IEmployee = SolidPatterns.DependencyInversionPrinciple.IEmployee;

//IFruit fruit = new Apple();
//Console.WriteLine(fruit.GetColor());
//fruit = new Orange();
//Console.WriteLine(fruit.GetColor());

List<IEmployee> employee = new List<IEmployee>();
employee.Add(new Human());
Manager manager = new Manager(employee);
manager.Manage();