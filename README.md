# OpenClosedPrinciple
## Easy to understand OpenClosedPrinciple example

The example is about customers and based on the customerType a discount is granted when generating the invoice.

So the openclosedprinciple is preventing code like this:
```
if(customer.CustomerType == CustomerType.Bad)
        discount = 0
```
This is violating the OpenClosePrinciple because whenever a new customerType needs to be created that part of the logic needs to be changes.
Check out the code for the how to :-)
