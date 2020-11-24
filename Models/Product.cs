using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalShopCMS.Models
{
    public class Product
    {
        public Product()
        {
            productCategory = new HashSet<ProductCategory>();
            mediaItems = new HashSet<MediaItem>();
            purchases = new HashSet<Purchase>();
        }

        private ICollection<Purchase> purchases;

        public virtual ICollection<Purchase> Purchases
        {
            get { return purchases; }
            set { purchases = value; }
        }

        private ICollection<ProductCategory> productCategory;

        public virtual ICollection<ProductCategory> ProductCategory
        {
            get { return productCategory; }
            set { productCategory = value; }
        }

        private ICollection<MediaItem> mediaItems;

        public virtual ICollection<MediaItem> MediaItems
        {
            get { return mediaItems; }
            set { mediaItems = value; }
        }

        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public string Model { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
       
    }
}
