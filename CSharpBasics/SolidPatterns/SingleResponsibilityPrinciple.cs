using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns
{
    public class Report
    {
        public string Text { get; set; }

        public void GoToFirstPage()
        {
            Console.WriteLine("");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine($"{pageNumber}");
        }
    }

    public class Printer
    {
        public void Print(Report report)
        {
            Console.WriteLine(report);
        }
    }

}
