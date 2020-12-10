using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace SneakersShoesShop.Models
{

    public class Color
    {
        public int Id { get; set; }
        [Required]
        public string ColorName { get; set; }
        
        //Navigation property
        //public Product Product {get; set;}

    }
}