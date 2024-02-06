using KHP.Entities;
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
        string sha256(string sifre);
        List<OgunListVm> TarihlerArasiKisiOgunListeleme(DateTime baslangic, DateTime bitis, int id);
        List<OgunListVm>  TarihlerArasiKisiKategoriListeleme(DateTime baslangic, DateTime bitis, int id);
        int Create(KullaniciCreateVm createVm);
        bool CheckIfUserNameExist(string eposta);
        bool CheckIfPasswordOk(string sifre ,string sifretekrar);

        bool Authanticator (string eposta, string sifre);

        public Kullanici GetByUsername(string username);
    }
}
