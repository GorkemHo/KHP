using KHP.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.ViewModels
{
    public class GidaListVm
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Kalori { get; set; }
        public GidaTurleri GidaTuru { get; set; }
        public int? OgunID { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
    }
}
