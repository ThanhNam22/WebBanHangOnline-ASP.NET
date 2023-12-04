using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHangOnline.Models.EF
{
    [Table("tb_ProductCategory")]
    public class ProductCategory: CommonAbstract
    {
        public ProductCategory() { 
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}