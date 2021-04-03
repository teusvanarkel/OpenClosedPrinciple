using System.Collections.Generic;
using OpenClosedExample.Invoices;
using Repositories;

namespace OpenClosedExample.Services
{
    public interface IOrderService: IService
    {
        void CreateFakeOrders(IOrderRepository orderRepository);

        List<Invoice> CreateInvoices();
    }
}