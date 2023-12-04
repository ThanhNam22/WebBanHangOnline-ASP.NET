using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHangOnline.Models.EF
{
    [Table("tb_OrderDetail")]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public decimal Price { get; set; }
        public int Quality { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}