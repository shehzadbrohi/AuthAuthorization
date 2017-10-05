using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
using System.Web.Security;

namespace WebApplication9.Controllers
{
    public class LoginController : Controller
    {
        TAZEntities db = new TAZEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(tblUser frmData)
        {
            var chk = db.tblUsers.Where(x => x.UserID == frmData.UserID && x.Password == frmData.Password).SingleOrDefault();
            if (chk != null) 
            {
                Session["URL"] = chk.Pic;
                FormsAuthentication.SetAuthCookie(chk.UserID, false);
              return  RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

           
            
        }

        
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}