using OpenClosedExample.Invoices;
using OpenClosedExample.Models;

namespace OpenClosedExample
{
    internal class BestCustomerInvoice : Invoice
    {
        public BestCustomerInvoice(Order order)
        {
            Order = order;
            Discount = 20;
        }
    }
}