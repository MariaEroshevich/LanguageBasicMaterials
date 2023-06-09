﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;

        private IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employee)
        {
            _employees = employee;
            _employeeReport = new EmployeeReport();
        }

        public IEmployeeReportBuilder BuildHeader()
        {
            _employeeReport.Header = $"Employee report on date {DateTime.Now}";
            return this;
        }

        public IEmployeeReportBuilder BuildBody() 
        {
            _employeeReport.Body = string.Join(Environment.NewLine, 
                _employees.Select(x => $"Employee name: {x.Name}\t\tEmployee salary: {x.Salary}")) ;
            return this;
        }

        public IEmployeeReportBuilder BuildFooter()
        {
            _employeeReport.Footer = $"Total employees: {_employees.ToList().Count}";
            return this;
        }

        public EmployeeReport GetEmployeeReport()
        {
            return _employeeReport;
        }
    }
}