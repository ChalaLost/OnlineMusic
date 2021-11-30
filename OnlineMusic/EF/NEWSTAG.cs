namespace OnlineMusic.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEWSTAG")]
    public partial class NEWSTAG
    {
        [Key]
        [Column(Order = 0)]
        public long NewID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TagID { get; set; }
    }
}
