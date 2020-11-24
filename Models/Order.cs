using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalShopCMS.Models
{
    public class Order
    {
        public Order()
        {
            purchase = new HashSet<Purchase>();
        }

        private ICollection<Purchase> purchase;

        public virtual ICollection<Purchase> Purchase
        {
            get { return purchase; }
            set { purchase = value; }
        }
        [Key]
        public int OrderId { get; set; }
        public string Comments { get; set; }
        public DateTime DateTime { get; set; }
        public int OrderNumber { get; set; }
    }
}
