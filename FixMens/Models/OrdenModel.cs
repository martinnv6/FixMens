using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FixMens.Models
{
    public class OrdenModel
    {
        public string NombreCliente { get; set; }
        public string InfoTecnico { get; set; }
        public string InfoCliente { get; set; }
        public string Presupuesto { get; set; }
        public string Tecnico { get; set; }
        public string Precio { get; set; }
        public string ErrorMessage { get; set; }
    }
}