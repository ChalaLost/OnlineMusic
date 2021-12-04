namespace OnlineMusic.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHMUC")]
    public partial class DANHMUC
    {
        public long ID { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(200)]
        public string MetaTitle { get; set; }

        public long? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

<<<<<<< HEAD
=======
        [StringLength(200)]
        public string SeoTitle { get; set; }

>>>>>>> c48b6d3a532f2bfe31f5ed3b9c8977663fad31a9
        public bool? Status { get; set; }

        public bool? ShowOnHome { get; set; }
    }
}
