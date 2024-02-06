using KHP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Bll.IServices
{
    public interface IKullaniciService
    {
        List<OgunListVm> TarihlerArasiKisiOgunListeleme(DateTime baslangic, DateTime bitis, int id);
        List<OgunListVm>  TarihlerArasiKisiKategoriListeleme(DateTime baslangic, DateTime bitis, int id);
        int Create(KullaniciCreateVm createVm);
    }
}
