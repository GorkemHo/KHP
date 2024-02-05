using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Entities
{
    public class Ogun
    {
        public string Ad { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        //FR
        public int KullaniciID { get; set; }
        //NAV PROP
        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<Gida> Yemekler { get; set; }
    }
}
