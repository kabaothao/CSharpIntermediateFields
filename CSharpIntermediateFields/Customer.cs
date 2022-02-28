using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateFields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();  //This way no matter which constructor is going to be called the Order spell will always be initialized an empty list.


        public Customer(int id)
        {
            this.Id = id;
        }


        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }


        //read only file
        public void Promote()
        {
            Orders = new List<Order>();
        }

        /*
         First of all we can immediately see this error here by the red underline.

        It says read only field cannot be used as an assignment target.

        So if you don't see the read error when you compile the application you're definitely going to see that.

        So a read only field cannot be assigned to except in a constructor or a variable initializer.

        So what this means is this line is not acceptable and we can only initialize a read only field either

        here directly when we are declaring that or in the constructor.

        So Read-Only is one of the ways that you can improve the robustness of your application.
         */


    }
}


/*
 
 Now if you remember from the lecture about constructors I explained why we need to initialize these

orders to an empty list.

Just to recap whenever you have a class like customer and inside the class you have a list.

You should always initialize that list to an empty list.

        public Customer()
        {
            Order = new List<Order>(); //You should always initialize that list to an empty list.
                                       //We have to make sure that the default constructor is always called first. So the orders fill will be initialized.

        }


The approach you choose is up to you.

But what I want to emphasize to you is to be consistent with your approach.

Make sure you use the same approach everywhere.

This way your code would be cleaner.

 
 */