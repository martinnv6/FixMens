using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FixMens.BLL;

namespace FixMens.Controllers
{
    public class AdminController : Controller
    {

        private Admin _admin;
        internal Admin Admin
        {
            private get { return _admin = _admin ?? new Admin(); }
            set { _admin = value; }
        }

        // GET: Admin
        public ActionResult Index()
        {
            Admin.GetContarReparaciones();
            return View();
        }
    }
}