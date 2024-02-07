using KHP.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Entities
{
    public class KullaniciGida : BaseEntity
    {
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public string GidaAdi { get; set; }
        public string GidaTuru { get; set; }
        public decimal Kalori { get; set; }
        public decimal Porsiyon { get; set; }
        public string OgunAdi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

    }
}
