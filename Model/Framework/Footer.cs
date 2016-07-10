namespace DataLayer.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Footer")]
    public partial class Footer
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }

        [Column(TypeName = "NCLOB")]
        public string Content { get; set; }

        public bool? Status { get; set; }
    }
}
