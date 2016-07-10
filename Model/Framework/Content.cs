namespace DataLayer.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Content")]
    public partial class Content
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [StringLength(300)]
        public string MetaTitle { get; set; }

        public string Description { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        public int? CategoryId { get; set; }

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

        public bool Status { get; set; }

        public DateTime? TopHot { get; set; }

        public int? ViewCount { get; set; }

        [StringLength(300)]
        public string Tags { get; set; }
    }
}
