using KHP.Entities;
using KHP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Bll.IServices
{
    public interface IOgunService
    {
        int Create(OgunCreateVm vm);

        int Update(OgunUpdateVm vm);
        int Delete(int id);
        Ogun GetById(int id);
        List<OgunListVm> GetAll();

        List<OgunListVm> TarihlerArasıOgunListesi (DateTime baslangic, DateTime bitis);
        List<OgunListVm> TarihtekiOgunuGoster (DateTime tarih, int Id);

    }
}
