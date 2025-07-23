🧠 Task Title: Reporting System for Multiple File Formats
You're building a reporting system where reports can be exported in different formats such as PDF, Excel, CSV, and JSON. Each format has specific behaviors.

🔍 Requirements
1. Liskov Substitution Principle (LSP)
You should be able to substitute any report exporter (e.g., PDF, Excel) wherever a base type is expected, without breaking functionality.

2. Interface Segregation Principle (ISP)
Not all report formats support all features. For example:

Only PDF and Excel support Print().

All formats support Export().

Design your interfaces to respect ISP (no client should depend on methods it doesn't use).

🏗️ Specifications
Create a base interface (or abstract class) for report exporters.

Implement 4 exporters:

PdfExporter

ExcelExporter

CsvExporter

JsonExporter

Use dependency injection to resolve exporters.

The main function should:

Use DI to get an exporter by name (or type).

Call Export() and, if supported, Print().

📦 Bonus
Make it easy to add a new exporter without modifying existing logic (OCP).

Register exporters dynamically using a factory or dictionary.

📁 Example Usage:

var exporter = factory.GetExporter("Pdf");
exporter.Export("report data");
if (exporter is IPrintable printable)
{
    printable.Print();
}
