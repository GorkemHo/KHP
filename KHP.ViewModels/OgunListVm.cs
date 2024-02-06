using KHP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.ViewModels
{
    public class OgunListVm
    {
        public string Ad { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public int KullaniciID { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        
    }
}
