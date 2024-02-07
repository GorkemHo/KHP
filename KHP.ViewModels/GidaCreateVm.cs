using KHP.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.ViewModels
{
    public class GidaCreateVm
    {
        public string Ad { get; set; }
        public decimal Kalori { get; set; }
        public decimal Porsiyon { get; set; }
        public GidaTurleri GidaTuru { get; set; }

        //FR
        public int? OgunID { get; set; }
    }
}
