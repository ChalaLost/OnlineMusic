using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineMusic.EF;
using PagedList;
using PagedList.Mvc;

namespace OnlineMusic.DAO
{
    public class USER_DAO
    {
        OnlineMusicDB db = null;
        public USER_DAO() {
            db = new OnlineMusicDB();
        }

        public USER GetByID(string userName)
        {
            return db.USERs.SingleOrDefault(x => x.UserName == userName);
        }

        public USER ViewDetail(int id)
        {
            return db.USERs.Find(id);
        }

        public bool Insert(USER entity)
        {
            db.USERs.Add(entity);
            db.SaveChanges();
            return true;
        }
        public IEnumerable<USER> ListAllPaging(int page, int pageSize)
        {

            return db.USERs.OrderByDescending(x=>x.ID).ToPagedList(page, pageSize);
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

        public bool Update(USER entity)
        {
            try
            {
                var user = db.USERs.Find(entity.ID);
                user.UserName = entity.UserName;
                user.Name = entity.Name;
                user.Password = entity.Password;
                user.Address = entity.Address;
                user.Email = entity.Email;
                user.Phone = entity.Phone;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}