using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineMusic.EF;

namespace OnlineMusic.DAO
{
    public class USER_DAO
    {
        OnlineMusicDB db = null;
        public USER_DAO() {
            db = new OnlineMusicDB();
        }
        public long Insert(USER entity)
        {
            db.USERs.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public bool Login(string userName, string passWord)
        {
            var result = db.USERs.Count(x => x.UserName == userName && x.Password == passWord);
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}