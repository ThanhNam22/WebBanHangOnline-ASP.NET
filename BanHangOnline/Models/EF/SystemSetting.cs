using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHangOnline.Models.EF
{
    [Table("tb_SystemSetting")]
    public class SystemSetting
    {
        [Key]
        [StringLength(50)]
        public string SystemKey { get; set; }
        [StringLength(4000)]

        public string SystemValue { get; set; }
        [StringLength(4000)]

        public string SystemDescription { get; set; }
    }
}