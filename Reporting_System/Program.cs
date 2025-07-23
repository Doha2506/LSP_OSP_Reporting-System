using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Reporting_System.Interfaces;
using Reporting_System.Models;
using Reporting_System.Services;


var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<IExporterFactory, ExporterFactory>();
    })
    .Build();


var exporterFactory = host.Services.GetRequiredService<IExporterFactory>();

// register new format json

exporterFactory.RegisterNewFormat(ExportFormat.JSON, () => new JsonExporter());

var report = "You are late today";

var allFormats = Enum.GetValues(typeof(ExportFormat)).Cast<ExportFormat>().ToList();

foreach(var format in allFormats)
{
    var exporter = exporterFactory.GetExporter(format);

    exporter.Export(report);

    if (exporter is IPrintable printer)
    {
        printer.Print(report);
    }
    else
    {
        Console.WriteLine("This format " + format + " does't have Print function");
    }
}


