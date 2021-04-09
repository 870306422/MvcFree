namespace MvcFr.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stuinfo")]
    public partial class stuinfo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        [StringLength(20)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        public int ClassId { get; set; }

        public DateTime? AddTime { get; set; }

        public virtual classes classes { get; set; }
    }
}
