using KHP.ViewModels;
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
    }
}
