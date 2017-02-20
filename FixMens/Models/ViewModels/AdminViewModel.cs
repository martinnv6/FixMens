﻿using System;
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
        public List<AdminInfoModelUnion> ReparacionesPorTecnicoSemana { get; set; }



    }

    public class DetalleEgresos
    {
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public float Cantidad { get; set; }
        public string Descripcion { get; set; }
       



    }


}