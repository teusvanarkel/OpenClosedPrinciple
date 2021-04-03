using OpenClosedExample.Invoices;
using OpenClosedExample.Models;

namespace OpenClosedExample
{
    internal class GoodCustomerInvoice : Invoice
    {
        public GoodCustomerInvoice(Order order)
        {
            Order = order;
            Discount = 15;
        }
    }
}