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
    }
}