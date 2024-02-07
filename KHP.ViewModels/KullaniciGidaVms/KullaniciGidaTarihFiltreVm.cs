using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.ViewModels.KullaniciGidaVms
{
    public class KullaniciGidaTarihFiltreVm
    {
        
        public int KullaniciId { get; set; }
        public string GidaAdi { get; set; }
        public string GidaTuru { get; set; }
        public decimal Kalori { get; set; }
        public decimal Porsiyon { get; set; }
        public string OgunAdi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
    }
}
