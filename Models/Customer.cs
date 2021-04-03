using System.Collections.Generic;
using OpenClosedExample.Enums;

namespace OpenClosedExample.Models
{

    public class Customer :IModel
    {
        public string Name { get; set; }

        public CustomerType TypeCustomer {get;set;}

    }
}