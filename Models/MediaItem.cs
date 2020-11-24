using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalShopCMS.Models
{
    public class MediaItem
    {
        [Key]
        public int MediaItemId { get; set; }
        public string Name { get; set; }
        public string MediaType { get; set; }
        public string Path { get; set; }
        public virtual int? ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual int? BrandId { get; set; }
        public virtual Brand? Brand { get; set; }
        public virtual int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
