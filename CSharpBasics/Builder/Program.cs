using Builder;

var employees = new List<Employee>
{ 
    new Employee{Name = "Ivan", Salary = 100 },
    new Employee{Name = "Olga", Salary = 150 },
    new Employee{Name = "Oleg", Salary = 130 }
};

IEmployeeReportBuilder builder = new EmployeeReportBuilder(employees);
EmployeeReportDirector employeeReportDirector = new EmployeeReportDirector(builder);
employeeReportDirector.Build();

IEmployeeReportBuilder builder2;
builder2 = builder.BuildHeader().BuildBody().BuildFooter();

var report = builder.GetEmployeeReport();
Console.WriteLine(report.Header);