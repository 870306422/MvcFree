namespace MvcFr.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logen")]
    public partial class logen
    {
        [Key]
        [StringLength(20)]
        public string loge { get; set; }

        [Required]
        [StringLength(20)]
        public string pwd { get; set; }
    }
}
