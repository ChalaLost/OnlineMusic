using OnlineMusic.DAO;
using OnlineMusic.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMusic.EF;
using System.Data.Entity;

namespace OnlineMusic.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        // GET: Admin/User/Sua/5
        public ActionResult Sua(string userName)
        {    
            using (OnlineMusicDB dbModel = new OnlineMusicDB())
            {
                var kq = dbModel.USERs.Where(x => x.UserName == userName).FirstOrDefault();
                return View(kq);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Sua(string userName, USER user)
        {
            try
            {
                using (OnlineMusicDB dbModel = new OnlineMusicDB())
                {
                    dbModel.Entry(user).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Danhsach");
            }
            catch
            {
                return View();
            }
            
        }
        public ActionResult Them(USER user)
        {
            if (ModelState.IsValid)
            {
                var dao = new USER_DAO();
                var id = dao.Insert(user);
                if (id == true)
                {
                    return RedirectToAction("Danhsach", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Them user ko thanh cong");
                }
            }
            return View("Index");
        }
        public ActionResult Danhsach(int page = 1, int pageSize = 4)
        {
            var dao = new USER_DAO();
            var model = dao.ListAllPaging(page, pageSize);
            return View(model);
        }
    }
}