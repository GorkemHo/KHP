using KHP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Entities
{
    public class Kullanici : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Sifre { get; set; }
        
        
        
    }
}
