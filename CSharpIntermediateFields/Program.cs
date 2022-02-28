// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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


 */