namespace OnlineMusic.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        public long ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tài khoản")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [StringLength(100)]
        [Display(Name = "Họ tên")]
        public string Name { get; set; }

        [StringLength(150)]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

<<<<<<< HEAD
        [StringLength(100)]
        public string Phone { get; set; }

=======
        [StringLength(50)]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Trạng thái")]
>>>>>>> c48b6d3a532f2bfe31f5ed3b9c8977663fad31a9
        public bool? Status { get; set; }
    }
}
