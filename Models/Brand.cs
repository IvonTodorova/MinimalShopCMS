using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalShopCMS.Models
{
    public class Brand
    {
        public Brand()
        {
            products = new HashSet<Product>();
        }

        private ICollection<Product> products;
        public virtual ICollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        [Key]
        public int BrandId { get; set; }
        public string Name { get; set; }
        public virtual MediaItem MediaItem { get; set; }
        public string Description { get; set; }

    }
}
