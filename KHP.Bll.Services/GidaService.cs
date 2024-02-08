using KHP.Bll.IServices;
using KHP.Dal.IRepo;
using KHP.Dal.Repo;
using KHP.ViewModels.GidaVms;
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
                Kalori = g.Kalori,
                Porsiyon = g.Porsiyon,
                GidaTuru = g.GidaTuru,
                Resim = g.Resim,
            }).ToList();
            return _vm;
        }
    }
}
