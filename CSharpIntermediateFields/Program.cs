// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace CSharpIntermediateFields // Note: actual namespace depends on the project name.
{


     static class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
        }
    }
}


/*
 
 Agenda

*Initilization

*Read-only fields



Notes:

 Some developers believe we should use constructors only when we need to initialize our fields based

on the values passed from the outside.

So in this case we're initializing the orders field without any external varios the constructor as you

see here has no parameters.

So in situations like that there is another way to initialize the orders field and that looks like the

code you see here.


    public class Customer
    {
        List<Order> Orders;
            public Customer()
        {
            Orders = new List<Order>();

        }
    }

So in situations like that there is another way to initialize the orders field and that looks like the

code you see here.

So we can directly initialize the orders field without the need to create a constructor.


    public class Customer
        {
            List<Order> Orders = new List<Order>();
        }


This approach has an extra benefit and that is we can have multiple constructors and no matter which

one is called the orders field will always be initialized to an empty list.



* Read -only Fields
We can declare a field with the read only modifier to make sure that that field is only assigned to

once.

So in that case that field has to be initialized either directly like this.

Like you see here or in one of the constructors of the class.


    public class Customer 
    {
        readonly List<Order> Orders = new List<Order>();
    }




The reason is to create some kind of safety in our application to improve robustness.

For example take a look at this customer class here by declaring the orders field as read only.

I'll make sure that I will only have one list where we will keep the list of orders.

If I accidentally as a developer try to re-initialize this field in another method the data that we

had in the field will not be lost.

 */