using System.Collections.Generic;
using OpenClosedExample.Enums;
using OpenClosedExample.Invoices;
using OpenClosedExample.Models;
using Repositories;

namespace OpenClosedExample.Services
{
    public class OrderService:IOrderService
    {
        IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Invoice> CreateInvoices()
        {
            var orders = _orderRepository.GetAll();
            var invoices = new List<Invoice>();

            foreach (var order in orders)
            {
                var invoice = InvoiceFactory.Create(order);
                invoice.CalculateTotals();
                invoices.Add(invoice);
            }
            return invoices;
        }

        public void CreateFakeOrders(IOrderRepository orderRepository)
        {
            orderRepository.Add(new Order()
            {
                Product = new Product() { Description = "milt", Price = 100 },
                Customer = new Customer() { Name = "Bad", TypeCustomer = CustomerType.bad },
                Amount = 10
            });
            orderRepository.Add(new Order()
            {
                Product = new Product() { Description = "milt", Price = 100 },
                Customer = new Customer() { Name = "Good", TypeCustomer = CustomerType.good },
                Amount = 10
            });
            orderRepository.Add(new Order()
            {
                Product = new Product() { Description = "milt", Price = 100 },
                Customer = new Customer() { Name = "Best", TypeCustomer = CustomerType.best },
                Amount = 10
            });
        }

    }
}