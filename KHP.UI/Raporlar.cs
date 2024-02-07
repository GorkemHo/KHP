using KHP.Bll.IServices;
using KHP.Bll.Services;
using KHP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHP.UI
{
    public partial class Raporlar : Form
    {
        IKullaniciGidaService _kullaniciGidaService;
        IGidaService _gidaService;
        IKullaniciService _kullaniciService;
        IOgunService _ogunService;
        int _kullaniciId;
        List<GidaEklemeVm> secilenGidalar;
        public Raporlar(int kullaniciId)
        {
            InitializeComponent();
            _gidaService = new GidaService();
            _kullaniciService = new KullaniciService();
            _ogunService = new OgunService();
            _kullaniciId = kullaniciId;
            secilenGidalar = new List<GidaEklemeVm>();
            _kullaniciGidaService = new KullaniciGidaService();
        }
    }
}
