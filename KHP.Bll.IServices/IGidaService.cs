using KHP.ViewModels.GidaVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Bll.IServices
{
    public interface IGidaService
    {
        List<GidaListVm> GetAll();
    }
}
