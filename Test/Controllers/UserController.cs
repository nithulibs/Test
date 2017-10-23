using BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            object asd = new { asdfa = "",  };
            
            var a = new UserBLL().GetAll();
            return View();
        }
    }
}