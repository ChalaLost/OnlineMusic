namespace OnlineMusic.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        public long ID { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(200)]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [StringLength(800)]
        public string Description { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImage { get; set; }

        public decimal? Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        [Column(TypeName = "ntext")]
        public string Details { get; set; }

        public int? Quantity { get; set; }

        public bool? Status { get; set; }
    }
}
