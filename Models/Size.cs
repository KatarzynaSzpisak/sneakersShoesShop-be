using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace onlineTShirtShop.Models
{

    public class Size
    {
        public int Id { get; set; }
        [Required]
        public string SizeName { get; set; }
        
        //Navigation property
        //public Product Product {get; set;}

    }
}