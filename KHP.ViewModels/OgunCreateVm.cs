using KHP.Entities;
using KHP.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.ViewModels
{
    public class OgunCreateVm
    {
        public string Ad { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public int KullaniciID { get; set; }
        public virtual Gida Yemekler { get; set; }
        public string GidaAd { get; set; }
        public decimal Kalori { get; set; }
        public decimal Porsiyon { get; set; }
        public GidaTurleri GidaTuru { get; set; }
    }
}
