﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IEmployeeReportBuilder
    {
        public IEmployeeReportBuilder BuildHeader();

        public IEmployeeReportBuilder BuildBody();

        public IEmployeeReportBuilder BuildFooter();

        public EmployeeReport GetEmployeeReport();
    }
}
