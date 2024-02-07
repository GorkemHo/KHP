using KHP.Bll.IServices;
using KHP.Dal.Context;
using KHP.Dal.IRepo;
using KHP.Dal.Repo;
using KHP.Entities;
using KHP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Bll.Services
{
    public class KullaniciService : IKullaniciService
    {
        KullaniciRepo _kullaniciRepo;
        OgunRepo _ogunRepo;
        Kullanici kullanici;
        public KullaniciService()
        {
            _kullaniciRepo = new KullaniciRepo();
            _ogunRepo = new OgunRepo();
            kullanici = new Kullanici();
        }

        public bool Authanticator(string eposta, string sifre)
        {
            Kullanici kullanici= GetByUsername(eposta);
            if (kullanici==null||kullanici.Sifre!=sifre )
            {
                return false;   
            }
            return true;
        }
        public Kullanici GetByUsername(string username) { return _kullaniciRepo.GetAll().FirstOrDefault(a => a.Eposta == username); }
        public bool CheckIfPasswordOk(string sifre ,string sifretekrar)
        {
             
            return sifre.Length >= 8 && sifre.Count(char.IsUpper) >= 2 && sifre.Count(char.IsLower)>=3 && sifre.Equals(sifretekrar);
            
        }

        public bool CheckIfUserNameExist(string eposta)
        {
            return _kullaniciRepo.GetAll().Any(a => a.Eposta == eposta);
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

        public string sha256(string sifre)
        {
            using (SHA256 sha256 = SHA256Managed.Create()  )
            {
                return string.Concat(sha256.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(item => item.ToString("x2")));
                
            }
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
