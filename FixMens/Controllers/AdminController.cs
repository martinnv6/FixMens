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
        #region MVC
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
                ReparacionesPorTecnico = Admin.GetReparacionesPorTecnico(),
                EquiposIngresados = Admin.GetEquiposIngresados(),
                EquiposEntregados = Admin.GetEquiposEntregados(),
                ReparacionesPorTecnicoSemana = Admin.GetReparacionesPorTecnicoSemanal(),
                TotalMoneyEntregadosNoFacturados = Admin.GetEquiposEntregadosNoFacturados(),
                Compras = Admin.GetCompras()
                };
            return View(model);
        }

        public ActionResult MovementStatus(DateTime? fecha)
        {
            
            var model = Admin.GetMovementStatus(fecha);
            return View(model);

        }

        public ActionResult detalleEgresos(DateTime fecha)
        {
            List<DetalleEgresos> model = Admin.GetDetalleEgresos(fecha);

            return View(model);
        }

        public ActionResult DetalleVentas(DateTime fecha)
        {
            List<DetalleEgresos> model = Admin.GetDetalleVentas(fecha);
            return View(model);
        }

        public ActionResult DetalleReparaciones(string nombre)
        {
            List<ReparacionesModel> model = Admin.GetReparacionesPorTecnico_Detalle(nombre);
            return View(model);
        }
        //ToDo: reutilizar metodo de consulta y tambien la vista de los equipos
        public ActionResult DetalleEquipos(DateTime fecha, string tipoConsulta)
        {
            List<ReparacionesModel> model = Admin.GetEntregados_Detalle(fecha, tipoConsulta);
            ViewBag.tipoConsulta = tipoConsulta + " " + fecha.ToShortDateString();
            return View(model);
        }

        public ActionResult GetAnticiposEgresos(DateTime? fecha, bool soloAnticipos = true)
        {

            List<DetalleEgresos> model = Admin.GetAnticiposEgresos(fecha, soloAnticipos);
            return View(model);
        }


        //public ActionResult OrdenesDeReparacionPorTecnico(DateTime fechaInicio, DateTime fechaFin,int tecnico)
        //{
        //    return null;
        //}
        public ActionResult Arqueo()
        {
            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var endDate = DateTime.Now;

            CajaViewModel model = new CajaViewModel {tipoConsulta = "MesActual"};
            model.ArqueoList = Admin.GetArqueo(startDate, endDate, model.tipoConsulta);
            
            

            
            return View(model);
        }

        public ActionResult ArqueoMesAnterior()
        {
            var endDate = DateTime.Now.AddMonths(-1);
            var startDate = new DateTime(endDate.Year, endDate.Month, 1);
            

            CajaViewModel model = new CajaViewModel { tipoConsulta = "MesAnterior" };
            model.ArqueoList = Admin.GetArqueo(startDate, endDate, model.tipoConsulta);
            return View(model);
        }

        public ActionResult Conciliar()
        {

            CajaViewModel model = new CajaViewModel
            {
                tipoConsulta = "Conciliacion",
                ConciliacionList = Admin.GetConciliacion()
            };
            return View(model);
        }

        public ActionResult DetalleCompras(DateTime fecha)
        {
            List<DetalleCompras> model = Admin.GetDetalleCompras(fecha);
            return View(model);
        }

        public JsonResult GetApiEquipos()
        {
            AdminViewModel model = new AdminViewModel
            {
                EquiposEnTaller = Admin.GetTotalesEquiposEnTaller(),
                Ventas = Admin.GetVentasDia(),
                Egresos = Admin.GetEgresos(),
                ReparacionesPorTecnico = Admin.GetReparacionesPorTecnico(),
                EquiposIngresados = Admin.GetEquiposIngresados(),
                EquiposEntregados = Admin.GetEquiposEntregados(),
                ReparacionesPorTecnicoSemana = Admin.GetReparacionesPorTecnicoSemanal(),
                TotalMoneyEntregadosNoFacturados = Admin.GetEquiposEntregadosNoFacturados(),
                Compras = Admin.GetCompras()
            };
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
    #endregion
    #region API //Todo: Cambiar a api

   
    #endregion
}