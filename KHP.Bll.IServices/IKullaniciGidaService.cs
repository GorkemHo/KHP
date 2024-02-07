using KHP.ViewModels;
using KHP.ViewModels.KullaniciGidaVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Bll.IServices
{
    public interface IKullaniciGidaService
    {
        int Create(KullaniciGidaCreateVm vm);

        int Update(KullaniciGidaUpdateVm vm);
        int Delete(int id);
        List<KullaniciGidaListVm> GetAll();

        List<KullaniciGidaListVm> TarihlerArasiKisiOgunListeleme(DateTime baslangic, DateTime bitis, int id);

        List<KullaniciGidaListVm> TarihlerArasiKisiKategoriListeleme(DateTime baslangic, DateTime bitis, int id);

        List<KullaniciGidaListVm> TarihlerArasıOgunListesi(DateTime baslangic, DateTime bitis);
        List<KullaniciGidaListVm> TarihlerArasiKategoriListeleme(DateTime baslangic, DateTime bitis);

        List<KullaniciGidaListVm> TarihtekiOgunuGoster(DateTime tarih, int Id);
    }
}
