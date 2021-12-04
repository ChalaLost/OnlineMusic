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