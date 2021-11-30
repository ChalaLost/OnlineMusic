namespace OnlineMusic.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ABOUT")]
    public partial class ABOUT
    {
        public long ID { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(200)]
        public string MetaTitle { get; set; }

        [StringLength(800)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [Column(TypeName = "ntext")]
        public string Details { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBuy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBuy { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        public string MetaDescription { get; set; }

        public bool? Status { get; set; }
    }
}
