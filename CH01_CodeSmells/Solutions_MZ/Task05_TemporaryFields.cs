using System;

namespace CH01_CodeSmells_MZ.Solutions_MZ;

public static class Task05_TemporaryFields
{
    public sealed class InvoiceGenerator
    {
        public void GenerateInvoice()
        {
            int invoiceNumber = GenerateInvoiceNumber();
            using var writer = new PdfWriter($"Invoice_{invoiceNumber}.pdf");

            writer.Write("Invoice Content");
        }

        private int GenerateInvoiceNumber() => 12345;
    }

    public sealed class PdfWriter : IDisposable
    {
        private readonly string _fileName;

        public PdfWriter(string fileName)
        {
            _fileName = fileName;
            Console.WriteLine($"[PdfWriter] Open: {_fileName}");
        }

        public void Write(string content)
        {
            Console.WriteLine($"[PdfWriter] Writing: {content}");
        }

        public void Dispose()
        {
            Console.WriteLine($"[PdfWriter] Close: {_fileName}");
        }
    }

    // TEST
    public static void Run()
    {
        Console.WriteLine("[05] Temporary Fields");

        var generator = new InvoiceGenerator();
        generator.GenerateInvoice();

        Console.WriteLine("Expected: Open -> Writing -> Close (in this order).");
    }
}
