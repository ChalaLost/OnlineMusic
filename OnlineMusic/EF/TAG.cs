namespace OnlineMusic.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAG")]
    public partial class TAG
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
