using OpenClosedExample.Invoices;
using OpenClosedExample.Models;

namespace OpenClosedExample
{
    internal class BadCustomerInvoice : Invoice
    {
        public BadCustomerInvoice(Order order)
        {
            Order = order;
            Discount = 0;
        }
    }
}