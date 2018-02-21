namespace Assingnment_1_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table1
    {
        [Key]
        public int cost { get; set; }

        [Required]
        [StringLength(10)]
        public string Cars { get; set; }

        [Required]
        [StringLength(10)]
        public string Bikes { get; set; }

        [Required]
        [StringLength(10)]
        public string Trucks { get; set; }

        public virtual Table1 Table11 { get; set; }

        public virtual Table1 Table12 { get; set; }
    }
}
