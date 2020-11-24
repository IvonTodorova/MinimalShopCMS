using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalShopCMS.Models
{
    public class User
    {
        public User()
        {
             orders = new HashSet<Order>();
        }

        private ICollection<Order> orders;

        public ICollection<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }
        [MaxLength(100)]
        public string AutificationKey { get; set; }
        public string SessionKey { get; set; }
        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(250)]
        public string Adress { get; set; }
        public string ShippingAdress { get; set; }
        [Required]
        public string Town { get; set; }
        public string Telephone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public UserCategoryEnum UserCategory { get; set; }
    }
}
