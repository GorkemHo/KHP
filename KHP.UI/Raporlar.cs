using KHP.Bll.IServices;
using KHP.Bll.Services;
using KHP.ViewModels.GidaVms;
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
        int _kullaniciId;
        List<GidaEklemeVm> secilenGidalar;
        public Raporlar(int kullaniciId)
        {
            InitializeComponent();
            _gidaService = new GidaService();
            _kullaniciService = new KullaniciService();
            _kullaniciId = kullaniciId;
            secilenGidalar = new List<GidaEklemeVm>();
            _kullaniciGidaService = new KullaniciGidaService();
        }

        private void btnOgunBazliListele_Click(object sender, EventArgs e)
        {
            dgvHerkes.DataSource = null;
            dgvKisi.DataSource = null;

            dgvKisi.DataSource = _kullaniciGidaService.TarihlerArasiKisiOgunListeleme(dtpBaslangic.Value.Date, dtpBitis.Value.Date, _kullaniciId);
            dgvHerkes.DataSource = _kullaniciGidaService.TarihlerArasıOgunListesi(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void btnKategoriBazliListele_Click(object sender, EventArgs e)
        {
            dgvHerkes.DataSource = null;
            dgvKisi.DataSource = null;

            dgvKisi.DataSource = _kullaniciGidaService.TarihlerArasiKisiKategoriListeleme(dtpBaslangic.Value.Date, dtpBitis.Value.Date, _kullaniciId);
            dgvHerkes.DataSource = _kullaniciGidaService.TarihlerArasiKategoriListeleme(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void btnOgunlereGoreListeleAzalan_Click(object sender, EventArgs e)
        {
            dgvFiltreliList.DataSource = null;
            dgvFiltreliList.DataSource = _kullaniciGidaService.OgunlereGoreAzalan();
        }

        private void btnYemeklereGoreListeleAzalan_Click(object sender, EventArgs e)
        {
            dgvFiltreliList.DataSource = null;
            dgvFiltreliList.DataSource = _kullaniciGidaService.GidaAdinaGoreAzalan();
        }

     
    }
}
