using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        [HttpPost]
        public JsonResult facturar(FacturaModel model)
        {
            try
            {
                Admin.sendEmailToCreateInvoice(model);
                return Json("La factura llegara a su correo en maximo 24hrs", JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception e)
            {
                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult DetalleOrden(string nombre, int orden, string admin = "")
        {
            Orden bllOrden = new Orden();
            var model = bllOrden.ConsultarOrden(nombre, orden, admin);
            if (model.NombreCliente == null)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Content(model.ErrorMessage, MediaTypeNames.Text.Plain);
            }
            return View(model);
        }

        
    }
}