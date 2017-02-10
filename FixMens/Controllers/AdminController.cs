using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FixMens.BLL;
using FixMens.Models.ViewModels;

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
            AdminViewModel model = new AdminViewModel
            {
                EquiposEnTaller = Admin.GetTotalesEquiposEnTaller(),
                Ventas = Admin.GetVentasDia(),
                Egresos = Admin.GetEgresos(),
                ReparacionesPorTecnico = Admin.GetReparacionesPorTecnico()
            };
            return View(model);
        }
    }
}