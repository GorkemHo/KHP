using KHP.Bll.IServices;
using KHP.Dal.IRepo;
using KHP.Dal.Repo;
using KHP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Bll.Services
{
    public class GidaService : IGidaService
    {
        IGidaRepo _gidaRepo;
        public GidaService()
        {
            _gidaRepo = new GidaRepo();
        }





        public List<GidaListVm> GetAll()
        {
            List<GidaListVm> _vm = _gidaRepo.GetAll().Select(g => new GidaListVm
            {
                Id = g.ID,
                Ad = g.Ad,
                Kalori= g.Kalori,
                Porsiyon = g.Porsiyon,
                GidaTuru = g.GidaTuru,
                OgunID = g.OgunID
            }).ToList();
            return _vm;
        }

        public List<GidaListVm> TarihlerArasiKategoriListeleme(DateTime baslangic, DateTime bitis)
        {
            List<GidaListVm> _vms = _gidaRepo.GetAll().Where(gida => gida.Ogun.OlusturulmaTarihi >= baslangic && gida.Ogun.OlusturulmaTarihi <= bitis).Select(gida => new GidaListVm
            {
                Ad = gida.Ad,
                Kalori = gida.Kalori,
                Porsiyon = gida.Porsiyon,
                GidaTuru= gida.GidaTuru,
                OlusturulmaTarihi = gida.Ogun.OlusturulmaTarihi
            }).ToList();
            return _vms;
        }
    }
}
