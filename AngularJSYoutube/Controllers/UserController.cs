using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSYoutube.Models.EF;

namespace AngularJSYoutube.Controllers
{
    public class UserController : Controller
    {
        private AngularMcvDbContext db = null;

        public UserController()
        {
            db = new AngularMcvDbContext();
        }
        public JsonResult Index()
        {
           var users = db.Users.ToList();
              return Json(users, JsonRequestBehavior.AllowGet);

        }
    }
}