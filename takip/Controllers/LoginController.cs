using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using takip.Models;
namespace takip.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        IsTakipDBEntities entity = new IsTakipDBEntities(); 
        public ActionResult Index()
        {

            return View();
        }
    }
}