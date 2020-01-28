using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace onlineTShirtShop.Models
{

    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }

        
        //Navigation property
        //[JsonIgnore]
        public ICollection<OrderDetail> OrderDetails {get; set;}
        public Customer Customer {get; set;}

        internal void Remove(object toRemove)
        {
            throw new NotImplementedException();
        }
    }
}
