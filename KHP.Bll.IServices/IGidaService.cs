using KHP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Bll.IServices
{
    public interface IGidaService
    {
        List<GidaListVm> GetAll();
        //public List<GidaListVm> TarihlerArasiKategoriListeleme(DateTime baslangic, DateTime bitis);
    }
}
