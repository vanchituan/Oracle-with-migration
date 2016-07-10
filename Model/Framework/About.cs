namespace DataLayer.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("About")]
    public partial class About
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [StringLength(300)]
        public string MetaTitle { get; set; }

        public string Description { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        public string Detail { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(300)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(300)]
        public string ModifiedBy { get; set; }

        [StringLength(300)]
        public string MetaKeywords { get; set; }

        [StringLength(300)]
        public string MetaDescriptions { get; set; }

        public bool? Status { get; set; }
    }
}
