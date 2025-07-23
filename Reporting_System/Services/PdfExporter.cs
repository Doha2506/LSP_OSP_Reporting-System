using Reporting_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting_System.Services
{
    internal class PdfExporter : IExporter, IPrintable
    {
        public void Export(string report)
        {
            Console.WriteLine("export report in pdf and the report is : " + report);
        }

        public void Print(string report)
        {
            Console.WriteLine("print report in pdf and the report is : " + report);

        }
    }
}
