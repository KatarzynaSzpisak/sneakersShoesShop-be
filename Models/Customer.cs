using System;
using System.Collections.Generic;

namespace onlineTShirtShop.Models {

    public class Customer {
        public int Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Email {get;set;}
        public int Telephone {get; set;}
        public DateTime Registered {get; set;}

        public List<Order> Orders {get;set;}
    }
}