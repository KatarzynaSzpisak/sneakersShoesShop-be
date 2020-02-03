using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace onlineTShirtShop.Models
{

    public class Product
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ActualCost { get; set; }
        public string ImageUrl { get; set; }
        public string Details { get; set; }

        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public int MaterialId { get; set; }

        public Size Size { get; set; }
        public Material Material { get; set; }
        public Color Color { get; set; }
        // public object Products { get; internal set; }
    }
}

