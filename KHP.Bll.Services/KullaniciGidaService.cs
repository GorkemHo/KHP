using KHP.Bll.IServices;
using KHP.Dal.IRepo;
using KHP.Dal.Repo;
using KHP.Entities;
using KHP.ViewModels;
using KHP.ViewModels.KullaniciGidaVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Bll.Services
{
    public class KullaniciGidaService : IKullaniciGidaService
    {
        IKullaniciGidaRepo _kullaniciGidaRepo;


        public KullaniciGidaService()
        {
            _kullaniciGidaRepo = new KullaniciGidaRepo();
        }



        public int Create(KullaniciGidaCreateVm vm)
        {
            var kullaniciGida = new KullaniciGida
            {
                KullaniciId = vm.KullaniciId,
                GidaAdi = vm.GidaAdi,
                GidaTuru = vm.GidaTuru,
                Kalori = vm.Kalori,
                Porsiyon = vm.Porsiyon,
                OgunAdi = vm.OgunAdi,
                OlusturulmaTarihi = vm.OlusturulmaTarihi
            };
            return _kullaniciGidaRepo.Create(kullaniciGida);
        }

        public int Delete(int id)
        {
            var kullaniciGida = _kullaniciGidaRepo.GetById(id);
            if (kullaniciGida != null)
            {
                return _kullaniciGidaRepo.Delete(kullaniciGida);
            }
            return 0;
        }

        public List<KullaniciGidaListVm> GetAll()
        {
            List<KullaniciGidaListVm> kullaniciGidaList = _kullaniciGidaRepo.GetAll().Select(x => new KullaniciGidaListVm
            {
                Id =x.ID,
                KullaniciId = x.KullaniciId,
                GidaAdi = x.GidaAdi,
                GidaTuru = x.GidaTuru,
                Kalori = x.Kalori,
                Porsiyon = x.Porsiyon,
                OgunAdi = x.OgunAdi,
                OlusturulmaTarihi = x.OlusturulmaTarihi
            }).ToList();
            return kullaniciGidaList;
        }

        public List<KullaniciGidaListVm> TarihlerArasiKategoriListeleme(DateTime baslangic, DateTime bitis)
        {
            List<KullaniciGidaListVm> _vms = _kullaniciGidaRepo.GetAll().Where(gida => gida.OlusturulmaTarihi >= baslangic && gida.OlusturulmaTarihi <= bitis).Select(gida => new KullaniciGidaListVm
            {
                OgunAdi = gida.OgunAdi,
                OlusturulmaTarihi = gida.OlusturulmaTarihi,
                GidaAdi = gida.GidaAdi,
                GidaTuru = gida.GidaTuru,
                Porsiyon = gida.Porsiyon,
                Kalori = gida.Kalori

            }).ToList();
            return _vms;
        }

        public List<KullaniciGidaListVm> TarihlerArasiKisiKategoriListeleme(DateTime baslangic, DateTime bitis, int id)
        {
            List<KullaniciGidaListVm> _vms = _kullaniciGidaRepo.GetAll().Where(x => (x.ID == id) & (x.OlusturulmaTarihi > baslangic) & (x.OlusturulmaTarihi < bitis)).OrderBy(c => c.GidaTuru).Select(z => new KullaniciGidaListVm
            {
                OgunAdi = z.OgunAdi,
                OlusturulmaTarihi = z.OlusturulmaTarihi,
                GidaAdi = z.GidaAdi,
                GidaTuru = z.GidaTuru,
                Porsiyon = z.Porsiyon,
                Kalori = z.Kalori


            }).ToList();
            return _vms;
        }

        public List<KullaniciGidaListVm> TarihlerArasiKisiOgunListeleme(DateTime baslangic, DateTime bitis, int id)
        {
            List<KullaniciGidaListVm> _vms = _kullaniciGidaRepo.GetAll().Where(x => (x.ID == id) & (x.OlusturulmaTarihi > baslangic) & (x.OlusturulmaTarihi < bitis)).OrderBy(c => c.OgunAdi).Select(z => new KullaniciGidaListVm
            {
                OgunAdi = z.OgunAdi,
                OlusturulmaTarihi = z.OlusturulmaTarihi,
                GidaAdi = z.GidaAdi,
                GidaTuru = z.GidaTuru,
                Porsiyon = z.Porsiyon,
                Kalori = z.Kalori

            }).ToList();
            return _vms;
        }

        public List<KullaniciGidaListVm> TarihlerArasıOgunListesi(DateTime baslangic, DateTime bitis)
        {
            List<KullaniciGidaListVm> _vms = _kullaniciGidaRepo.GetAll().Where(x => x.OlusturulmaTarihi > baslangic && x.OlusturulmaTarihi < bitis).Select(z => new KullaniciGidaListVm
            {
                OgunAdi = z.OgunAdi,
                OlusturulmaTarihi = z.OlusturulmaTarihi,
                GidaAdi = z.GidaAdi,
                GidaTuru = z.GidaTuru,
                Porsiyon = z.Porsiyon,
                Kalori = z.Kalori
            }).ToList();
            return _vms;
        }

        public List<KullaniciGidaListVm> TarihtekiOgunuGoster(DateTime tarih, int Id)
        {
            List<KullaniciGidaListVm> _vms = _kullaniciGidaRepo.GetAll().Where(x => x.OlusturulmaTarihi == tarih && x.KullaniciId == Id).Select(z => new KullaniciGidaListVm
            {
                OgunAdi = z.OgunAdi,
                OlusturulmaTarihi = z.OlusturulmaTarihi,
                GidaAdi = z.GidaAdi,
                GidaTuru = z.GidaTuru,
                Porsiyon = z.Porsiyon,
                Kalori = z.Kalori
            }).ToList();
            return _vms;
        }

        public int Update(KullaniciGidaUpdateVm vm)
        {
            var kullaniciGidaUpdate = _kullaniciGidaRepo.GetById(vm.Id);
            if (kullaniciGidaUpdate != null)
            {
                vm.GidaAdi = kullaniciGidaUpdate.GidaAdi;
                vm.GidaTuru = kullaniciGidaUpdate.GidaTuru;
                vm.Kalori = kullaniciGidaUpdate.Kalori;
                vm.Porsiyon = kullaniciGidaUpdate.Porsiyon;
                vm.OgunAdi = kullaniciGidaUpdate.OgunAdi;
                vm.OlusturulmaTarihi = kullaniciGidaUpdate.OlusturulmaTarihi;

                return _kullaniciGidaRepo.Update(kullaniciGidaUpdate);
            }            
            return 0;

        }
    }
}
