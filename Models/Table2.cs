namespace Assingnment_1_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table2
    {
        [Key]
        [Column(Order = 0)]
        public int cost { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Trains { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Planes { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Rockets { get; set; }
    }
}
