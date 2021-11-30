namespace OnlineMusic.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CASI")]
    public partial class CASI
    {
        [Key]
        public long SingerID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string MetaTitle { get; set; }

        [StringLength(800)]
        public string Desciption { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public long? CategoryID { get; set; }

        [Column(TypeName = "ntext")]
        public string Details { get; set; }

        public int? ViewCount { get; set; }

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
    }
}
