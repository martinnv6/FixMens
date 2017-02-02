using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using FixMens.BLL;
using FixMens.Models;

namespace FixMens.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ConsultarOrden()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DetalleOrden(string nombre, int orden)
        {
            Orden bllOrden = new Orden();
            var model = bllOrden.ConsultarOrden(nombre, orden);
            if (model.NombreCliente == null)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Content(model.ErrorMessage, MediaTypeNames.Text.Plain);
            }
            return View(model);
        }

        
    }
}