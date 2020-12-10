using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace SneakersShoesShop.Models
{

    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public int MaterialId { get; set; }

        

        
        //Navigation property
        public Product Product { get; set; }
        [JsonIgnore]
        public Order Order { get; set; }
        public Size Size { get; set; }
        public Material Material { get; set; }
        public Color Color { get; set; }


    }
}
