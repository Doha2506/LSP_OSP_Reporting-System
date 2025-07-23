using Reporting_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting_System.Services
{
    internal class ExcelExporter : IExporter, IPrintable
    {
        public void Export(string report)
        {
            Console.WriteLine("export report in excel and the report is : " + report);
        }

        public void Print(string report)
        {
            Console.WriteLine("print report in excel and the report is : " + report);

        }
    }
}
