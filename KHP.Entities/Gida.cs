using KHP.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Entities
{
    public class Gida
    {
        public string Ad { get; set; }
        public decimal Kalori { get; set; }
        public GidaTurleri GidaTuru { get; set; }

        //FR
        public int? OgunID { get; set; }
        //NAV PROP
        public virtual Ogun? Ogun { get; set; }
    }
}
