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

        [StringLength(10)]
        public string Meta { get; set; }

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

        public long? CategoryID { get; set; }
    }
}
