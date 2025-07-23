using Reporting_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting_System.Interfaces
{
    internal interface IExporterFactory
    {
        void RegisterNewFormat(ExportFormat format, Func<IExporter> func);

        IExporter GetExporter(ExportFormat format);
    }
}
