using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FixMens.Models
{
    public class AdminInfoModel
    {
        public string Description { get; set; }
        public int Cant { get; set; }
    }

    public class AdminInfoModelUnion
    {
        public string Description { get; set; }
        public int Cant { get; set; }
        public string Description2 { get; set; }
        public int Cant2 { get; set; }
    }
}