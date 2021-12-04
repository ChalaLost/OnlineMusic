using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMusic.Common
{
    [Serializable]
    public class UserLogin
    {
        public long UserID { set; get; }
        public string UserName { set; get; } 
    }
}