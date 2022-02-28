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
        public List<Order> Order;  

        public Customer()
        {
            Order = new List<Order>(); //You should always initialize that list to an empty list.
        }
        public Customer(int id)
        {
            this.Id = id;
        }


        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

    }
}


/*
 
 Now if you remember from the lecture about constructors I explained why we need to initialize these

orders to an empty list.

Just to recap whenever you have a class like customer and inside the class you have a list.

You should always initialize that list to an empty list.



 
 */