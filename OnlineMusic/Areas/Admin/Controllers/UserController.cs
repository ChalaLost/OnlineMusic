using OnlineMusic.DAO;
using OnlineMusic.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineMusic.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Them(USER user)
        {
            if (ModelState.IsValid)
            {
                var dao = new USER_DAO();
                long id = dao.Insert(user);
                if (id > 0)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Them user ko thanh cong");
                }
            }
            return View("Index");
        }
        /*public ActionResult Sua(USER user)
        {
            return View("Index");
        }*/
    }
}