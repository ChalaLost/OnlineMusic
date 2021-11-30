namespace OnlineMusic.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LIENHE")]
    public partial class LIENHE
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }
    }
}
