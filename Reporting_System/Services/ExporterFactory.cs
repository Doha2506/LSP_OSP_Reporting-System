using Reporting_System.Interfaces;
using Reporting_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting_System.Services
{
    internal class ExporterFactory : IExporterFactory
    {
        private readonly Dictionary<ExportFormat, Func<IExporter>> _formats;

        public ExporterFactory()
        {
            _formats = new Dictionary<ExportFormat, Func<IExporter>>();

            RegisterDefaultFormats();
        }

        private void RegisterDefaultFormats()
        {
            _formats.Add(ExportFormat.PDF, () => new PdfExporter());    
            _formats.Add(ExportFormat.Excel, () => new ExcelExporter());    
            _formats.Add(ExportFormat.CSV, () => new CsvExporter());
        }


        public IExporter GetExporter(ExportFormat format)
        {
            if (!_formats.ContainsKey(format))
            {
                throw new ArgumentException("Not found format " + format);
            }
            return _formats[format]();
        }


        public void RegisterNewFormat(ExportFormat format, Func<IExporter> func)
        {
            _formats.Add(format, func);
        }
    }
}
