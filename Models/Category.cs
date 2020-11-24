using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalShopCMS.Models
{
    public class Category
    {
        public Category()
        {
            productCategory = new HashSet<ProductCategory>();
            mediaItems = new HashSet<MediaItem>();
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
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
    }
}
