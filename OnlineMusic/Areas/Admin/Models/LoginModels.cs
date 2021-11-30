using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMusic.Areas.Admin.Models
{
    public class LoginModels
    {
        [Required(ErrorMessage ="Mời nhập username!!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mời nhập password!!")]
        public string PassWord { get; set; }
        public bool RememberMe { get; set; }

    }
}