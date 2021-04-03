using OpenClosedExample.Enums;
using OpenClosedExample.Invoices;
using OpenClosedExample.Models;

namespace OpenClosedExample.Invoices
{
    public class InvoiceFactory
    {
        public static Invoice Create(Order order)
        {
            switch (order.Customer.TypeCustomer)
            {
                case CustomerType.good:
                    return new GoodCustomerInvoice(order);
                case CustomerType.best:
                    return new BestCustomerInvoice(order);
                case CustomerType.bad:
                    return new BadCustomerInvoice(order);
                default:
                    throw new System.Exception("Invoice not found for this customer type");
            } 

        }
    }
}