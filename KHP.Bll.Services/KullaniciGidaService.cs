using KHP.Bll.IServices;
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
                KullaniciId=vm.KullaniciId,
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
            }
            return 0;

        }
    }
}
