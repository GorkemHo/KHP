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
    public class OgunService : IOgunService
    {
        IOgunRepo _ogunRepo;
        public OgunService()
        {
            _ogunRepo = new OgunRepo();
        }

        public int Create(OgunCreateVm vm)
        {
            var ogun = new Ogun
            {

                Ad = vm.Ad,
                OlusturulmaTarihi = vm.OlusturulmaTarihi,
                KullaniciID = vm.KullaniciID,
                Yemekler = vm.Yemekler

            };
            return _ogunRepo.Create(ogun);
        }

        public int Delete(int id)
        {

            var ogun = _ogunRepo.GetById(id);
            if (ogun != null)
            {
                return _ogunRepo.Delete(ogun);
            }
            return 0;

        }

        public List<OgunListVm> GetAll()
        {
            List<OgunListVm> ogunList = _ogunRepo.GetAll().Select(x => new OgunListVm
            {
                KullaniciID = x.KullaniciID,
                Ad = x.Ad,
                OlusturulmaTarihi = x.OlusturulmaTarihi

            }).ToList();
            return ogunList;
        }

        public Ogun GetById(int id)
        {
            return _ogunRepo.GetById(id);
        }

        public List<OgunListVm> TarihlerArasıOgunListesi(DateTime baslangic, DateTime bitis)
        {
            List<OgunListVm> ogunList = _ogunRepo.GetAll().Where(x => x.OlusturulmaTarihi > baslangic && x.OlusturulmaTarihi < bitis).Select(z => new OgunListVm
            {
                Ad = z.Ad,
                OlusturulmaTarihi = z.OlusturulmaTarihi,
            }).ToList();
            return ogunList;
        }

        public List<OgunListVm> TarihtekiOgunuGoster(DateTime tarih, int Id)
        {
            List<OgunListVm> ogunList = _ogunRepo.GetAll().Where(x => x.OlusturulmaTarihi == tarih && x.KullaniciID == Id).Select(z => new OgunListVm
            {

                //Ad = z.Ad,
                // OlusturulmaTarihi = z.OlusturulmaTarihi,
                Yemekler = z.Yemekler



            }).ToList();
            return ogunList;
        }


        public int Update(OgunUpdateVm vm)
        {
            var ogunUpdate = _ogunRepo.GetById(vm.KullaniciID);
            if (ogunUpdate != null)
            {
                vm.Ad = ogunUpdate.Ad;
                vm.OlusturulmaTarihi = ogunUpdate.OlusturulmaTarihi;

            }
            return 0;
        }
    }
}
