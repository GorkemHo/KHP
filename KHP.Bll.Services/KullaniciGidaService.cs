﻿using KHP.Bll.IServices;
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
        IKullaniciRepo _kullaniciRepo;

        public KullaniciGidaService()
        {
            _kullaniciGidaRepo = new KullaniciGidaRepo();
            _kullaniciRepo = new KullaniciRepo();
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
                Id = x.ID,
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

        public List<KullaniciGidaPorsiyonVm> GidaAdinaGoreAzalan()
        {
            List<KullaniciGidaPorsiyonVm> _vms = _kullaniciGidaRepo.GetAll().GroupBy(x => new { x.GidaAdi }).Select(group => new KullaniciGidaPorsiyonVm
            {

                GidaAdi = group.Key.GidaAdi,
                Porsiyon = group.Sum(x => x.Porsiyon)

            }).OrderByDescending(a => a.Porsiyon).ToList();
            return _vms;
        }

        public List<KullaniciGidaFiltreVm> OgunlereGoreAzalan()
        {
            
            List<KullaniciGidaFiltreVm> _vms = _kullaniciGidaRepo.GetAll().GroupBy(x => new { x.OgunAdi, x.GidaAdi }).Select(group => new KullaniciGidaFiltreVm
            {
                GidaAdi = group.Key.GidaAdi,
                OgunAdi = group.Key.OgunAdi,
                Porsiyon = group.Sum(x => x.Porsiyon)
                

            }).OrderByDescending(a => a.Porsiyon).ToList();
            return _vms;
        }

        public List<KullaniciGidaTarihFiltreVm> TarihlerArasiKategoriListeleme(DateTime baslangic, DateTime bitis)
        {
            List<KullaniciGidaTarihFiltreVm> _vms = _kullaniciGidaRepo.GetAll().Where(gida => gida.OlusturulmaTarihi >= baslangic && gida.OlusturulmaTarihi <= bitis).OrderBy(x => x.GidaTuru).Select(gida => new KullaniciGidaTarihFiltreVm
            {
                KullaniciId = gida.KullaniciId,
                OgunAdi = gida.OgunAdi,
                OlusturulmaTarihi = gida.OlusturulmaTarihi,
                GidaAdi = gida.GidaAdi,
                GidaTuru = gida.GidaTuru,
                Porsiyon = gida.Porsiyon,
                Kalori = gida.Kalori

            }).ToList();
            return _vms;
        }

        public List<KullaniciGidaTarihFiltreVm> TarihlerArasiKisiKategoriListeleme(DateTime baslangic, DateTime bitis, int id)
        {
            List<KullaniciGidaTarihFiltreVm> _vms = _kullaniciGidaRepo.GetAll().Where(x => x.KullaniciId == id && x.OlusturulmaTarihi > baslangic && x.OlusturulmaTarihi < bitis).OrderBy(c => c.GidaTuru).Select(z => new KullaniciGidaTarihFiltreVm
            {
                KullaniciId = z.KullaniciId,
                OgunAdi = z.OgunAdi,
                OlusturulmaTarihi = z.OlusturulmaTarihi,
                GidaAdi = z.GidaAdi,
                GidaTuru = z.GidaTuru,
                Porsiyon = z.Porsiyon,
                Kalori = z.Kalori


            }).ToList();
            return _vms;
        }

        public List<KullaniciGidaTarihFiltreVm> TarihlerArasiKisiOgunListeleme(DateTime baslangic, DateTime bitis, int id)
        {
            List<KullaniciGidaTarihFiltreVm> _vms = _kullaniciGidaRepo.GetAll().Where(x => x.KullaniciId == id && x.OlusturulmaTarihi > baslangic && x.OlusturulmaTarihi < bitis).OrderBy(c => c.OgunAdi).Select(z => new KullaniciGidaTarihFiltreVm
            {
                KullaniciId = z.KullaniciId,
                OgunAdi = z.OgunAdi,
                OlusturulmaTarihi = z.OlusturulmaTarihi,
                GidaAdi = z.GidaAdi,
                GidaTuru = z.GidaTuru,
                Porsiyon = z.Porsiyon,
                Kalori = z.Kalori

            }).ToList();
            return _vms;
        }

        public List<KullaniciGidaTarihFiltreVm> TarihlerArasıOgunListesi(DateTime baslangic, DateTime bitis)
        {
            List<KullaniciGidaTarihFiltreVm> _vms = _kullaniciGidaRepo.GetAll().Where(x => x.OlusturulmaTarihi > baslangic && x.OlusturulmaTarihi < bitis).OrderBy(x => x.OgunAdi).Select(z => new KullaniciGidaTarihFiltreVm
            {
                KullaniciId = z.KullaniciId,
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
            KullaniciGida kullaniciGidaUpdate = _kullaniciGidaRepo.GetById(vm.Id);
            kullaniciGidaUpdate.Kullanici = _kullaniciRepo.GetById(vm.KullaniciId);
            if (kullaniciGidaUpdate != null)
            {

                kullaniciGidaUpdate.KullaniciId = vm.KullaniciId;
                kullaniciGidaUpdate.GidaAdi = vm.GidaAdi;
                kullaniciGidaUpdate.GidaTuru = vm.GidaTuru;
                kullaniciGidaUpdate.Kalori = vm.Kalori;
                kullaniciGidaUpdate.Porsiyon = vm.Porsiyon;
                kullaniciGidaUpdate.OgunAdi = vm.OgunAdi;
                kullaniciGidaUpdate.OlusturulmaTarihi = vm.OlusturulmaTarihi;

                return _kullaniciGidaRepo.Update(kullaniciGidaUpdate);
            }
            return 0;
            

        }
    }
}
