using Reporting_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting_System.Services
{
    internal class JsonExporter : IExporter
    {
        public void Export(string report)
        {
            Console.WriteLine("export report in json and the report is : " + report);
        }
    }
}
