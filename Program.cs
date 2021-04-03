using OpenClosedExample.Invoices;

namespace OpenClosedExample
{
    class Program
    {
        static void Main(string[] args)
        {
               var invoiceManager = new InvoiceManager();
               invoiceManager.CreateInvoices();         
        }
    }
}
