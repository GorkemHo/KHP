using KHP.Bll.IServices;
using KHP.Dal.Context;
using KHP.Dal.IRepo;
using KHP.Dal.Repo;
using KHP.Entities;
using KHP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Bll.Services
{
    public class KullaniciService : IKullaniciService
    {
        KullaniciRepo _kullaniciRepo;
        OgunRepo _ogunRepo;
        public KullaniciService()
        {
            _kullaniciRepo = new KullaniciRepo();
            _ogunRepo = new OgunRepo();
        }
        public int Create(KullaniciCreateVm createVm)
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = createVm.Ad,
                Soyad = createVm.Soyad,
                Eposta = createVm.Eposta,
                Sifre = createVm.Sifre,
                Cinsiyet = createVm.Cinsiyet,
                DogumTarihi = createVm.DogumTarihi,
            };
            return _kullaniciRepo.Create(kullanici);
        }

        public List<OgunListVm> TarihlerArasiKisiKategoriListeleme(DateTime baslangic, DateTime bitis, int id)
        {
            List<OgunListVm> ogunListVms = _ogunRepo.GetAll().Where(x => (x.ID == id) & (x.OlusturulmaTarihi > baslangic) & (x.OlusturulmaTarihi < bitis)).OrderBy(c=> c.Yemekler).Select(z => new OgunListVm
            {
                Ad = z.Ad,
                KullaniciID = z.KullaniciID,
                OlusturulmaTarihi = z.OlusturulmaTarihi,
                

        }).ToList();
            return ogunListVms;
        }

        public List<OgunListVm> TarihlerArasiKisiOgunListeleme(DateTime baslangic, DateTime bitis, int id)
        {
            List<OgunListVm> ogunListVms = _ogunRepo.GetAll().Where(x => (x.ID == id) & (x.OlusturulmaTarihi > baslangic) & (x.OlusturulmaTarihi < bitis)).OrderBy(c=> c.Ad).Select(z => new OgunListVm
            {
                Ad = z.Ad,
                KullaniciID = z.KullaniciID,
                OlusturulmaTarihi = z.OlusturulmaTarihi

            }).ToList();
            return ogunListVms;
        }
    }
}
