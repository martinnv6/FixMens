using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FixMens.Models.ViewModels
{
    public class AdminViewModel
    {
        public List<AdminInfoModel> EquiposEnTaller { get; set; }
        public List<AdminInfoModel> Ventas { get; set; }
        public List<AdminInfoModel> Egresos { get; set; }
        public List<AdminInfoModel> ReparacionesPorTecnico { get; set; }
        public List<AdminInfoModel> EquiposIngresados { get; set; }
        public List<AdminInfoModel> EquiposEntregados { get; set; }
        
        public List<AdminInfoModelUnion> ReparacionesPorTecnicoSemana { get; set; }
        public float TotalMoneyEntregadosNoFacturados { get; set; }



    }

    public class DetalleEgresos
    {
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public float Cantidad { get; set; }
        public string Descripcion { get; set; }
       



    }

    public class ReparacionesModel
    {
        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Falla { get; set; }
        public string InformeTeller { get; set; }
        public string DetallePresupuesto { get; set; }
        public string HoraTerminado { get; set; }
        public char Entregado { get; set; }
        public char Facturado { get; set; }
        public string FechaEntrega { get; set; }
        public float Total { get; set; }    

    }

    public class ArqueoViewModel
    {
        public DateTime Fecha { get; set; }
        public decimal InicioCaja { get; set; }
        public decimal Declarado { get; set; }
        public decimal Calculado { get; set; }
        public decimal Diferencia { get; set; }
    }

    public class ConciliacionViewModel
    {
        public DateTime Fecha { get; set; }
        public decimal InicioCaja { get; set; }
        public decimal Declarado { get; set; }
        public decimal Calculado { get; set; }
        public decimal Diferencia { get; set; }
        public decimal NoFacturados { get; set; }
        public decimal Conciliacion { get; set; }
    }

    public class CajaViewModel
    {
        public string tipoConsulta { get; set; }
        public List<ArqueoViewModel> ArqueoList { get; set; }
        public List<ConciliacionViewModel> ConciliacionList { get; set; }
        
    }


}