using System;
using OpenClosedExample.Models;

namespace OpenClosedExample.Invoices
{
    public class Invoice
    {
        public Order Order { get; set; }

        public int Discount { get; set; } = 5;
        public decimal Total { get; set; }

        public virtual void CalculateTotals()
        {
            Total = (Order.Amount * Order.Product.Price) * (100 - Discount);
        }
    }
}