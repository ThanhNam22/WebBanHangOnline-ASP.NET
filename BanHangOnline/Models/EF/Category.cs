using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHangOnline.Models.EF
{
    [Table("tb_Category")]
    public class Category : CommonAbstract
    {
        public Category()
        {
            this.News = new HashSet<News>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên danh mục chưa được để trống")]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        [StringLength(150)]

        public string SeoTitle {  get; set; }
        [StringLength(250)]

        public string SeoDescription { get; set;}
        [StringLength(150)]

        public string SeoKeywords { get; set; }
        public bool IsActive { get; set; }

        public int Position { get; set; }
        public ICollection<News> News { get; set;}
        public ICollection<Posts> Posts { get; set; }
    }
}