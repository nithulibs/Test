using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Models.RegisterViewModel objVM)
        {
            if (ModelState.IsValid)
            {
                User objUser = new DAL.User()
                {
                    Name = objVM.FirstName,
                    Email = objVM.Email,
                    Password = objVM.Password
                };

                new BLL.UserBLL().Add(objUser);
            }

            return View();
        }
    }
}