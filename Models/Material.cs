using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace sneakersShoesShop.Models
{

    public class Material
    {
        public int Id { get; set; }
        [Required]
        public string MaterialName { get; set; }
        
        //Navigation property
        //public Product Product {get; set;}

    }
}