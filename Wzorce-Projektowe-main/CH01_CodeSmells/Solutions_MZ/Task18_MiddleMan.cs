using System;

namespace Solutions_MZ;

public static class Task18_MiddleMan
{
    public sealed class Invoice
    {
        public int Id { get; }
        public string Description { get; }

        public Invoice(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }

    public sealed class InvoiceRepository
    {
        public Invoice GetInvoiceById(int id)
        {
            return new Invoice(id, "Sample invoice");
        }

        public void SaveInvoice(Invoice invoice)
        {
            Console.WriteLine($"Invoice saved: {invoice.Id} ({invoice.Description})");
        }
    }

    //zgodnie z poleceniem: brak klasy InvoiceService (middle man)
    public sealed class InvoiceController
    {
        private readonly InvoiceRepository _repository = new InvoiceRepository();

        public void SaveSampleInvoice()
        {
            var invoice = _repository.GetInvoiceById(1);
            _repository.SaveInvoice(invoice);
        }
    }

    public static void Run()
    {
        Console.WriteLine("[18] Middle Man");

        var controller = new InvoiceController();
        controller.SaveSampleInvoice();

        Console.WriteLine("Expected: Invoice saved: 1 (Sample invoice)");
    }
}
