# OpenClosedPrinciple
## Easy to understand OpenClosedPrinciple example

The example is about a invoicemanager which creates the invoices. 
Next to that there are orders, customers and customerTypes. 
Based on customer type the discount for an order is managed.

So the openclosedprinciple is preventing code like this:
```
if(customer.CustomerType == CustomerType.Bad)
        discount = 0
```
This is violating the OpenClosePrinciple because whenever a new customerType needs to be created that part of the logic needs to be changes.
Check out the code for the how to :-)
