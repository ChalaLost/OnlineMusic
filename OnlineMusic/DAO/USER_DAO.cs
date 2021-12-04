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
        public USER GetByID(string userName)
        {
            return db.USERs.SingleOrDefault(x=>x.UserName == userName);
        }
        public int Login(string userName, string password)
        {
            var result = db.USERs.SingleOrDefault(x => x.UserName == userName);
            if (result == null)
            {
                return 0;
            }
            var result2 = db.USERs.Where(x => x.UserName == userName && x.Password == password).Count();
            if (result2 == 0)
            {
                return -2;
            }
             
            else
            {
                if(result.Status == false)
                {
                    return -1;
                }
                else
                {
                    if (result.Password == password)
                        return 1;
                    else
                        return -2;
                }
            }
        }
    }
}