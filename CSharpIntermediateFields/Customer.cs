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
        public List<Order> Orders = new List<Order>();  //This way no matter which constructor is going to be called the Order spell will always be initialized an empty list.


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

        }


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