using KHP.Bll.IServices;
using KHP.Bll.Services;
using KHP.Entities;
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
    public partial class AnaMenu : Form
    {
        IGidaService _gidaService;
        IKullaniciService _kullaniciService;
        IOgunService _ogunService;
        int _kullaniciId;
        List<GidaEklemeVm> secilenGidalar;


        public AnaMenu(int kullaniciId)
        {
            InitializeComponent();
            _gidaService = new GidaService();
            _kullaniciService = new KullaniciService();
            _ogunService = new OgunService();
            _kullaniciId = kullaniciId;
            secilenGidalar = new List<GidaEklemeVm>();
        }
        private void AnaMenu_Load(object sender, EventArgs e)
        {
            dgwGidalar.DataSource = _gidaService.GetAll();
            SorguButonlariniKapat();
            DetayButonlariniKapat();
        }

        private void txtAramaMetni_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtAramaMetni.Text;

            if (!string.IsNullOrEmpty(aramaMetni))
            {
                List<GidaListVm> arananGidalar = _gidaService.GetAll().Where(gida => gida.Ad.ToLower().Contains(aramaMetni.ToLower())).ToList();
                dgwGidalar.DataSource = arananGidalar;
            }
        }



        private void dgwGidalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SorguButonlariniAc();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgwGidalar.Rows[e.RowIndex];

                txtSecilenUrunAdi.Text = selectedRow.Cells["Ad"].Value.ToString();
                txtSecilenUrunPorsiyon.Text = selectedRow.Cells["Porsiyon"].Value.ToString();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            secilenGidalar.Add(new GidaEklemeVm
            {
                
                GidaAdi = txtSecilenUrunAdi.Text,
                Porsiyon = Convert.ToDecimal(txtSecilenUrunPorsiyon.Text),
                Kalori = Convert.ToDecimal(txtSecilenUrunPorsiyon.Text) * (decimal)dgwGidalar.CurrentRow.Cells["Kalori"].Value,
                GidaTuru = (string)dgwGidalar.CurrentRow.Cells["GidaTuru"].Value,
                OlusturulmaTarihi = dtpOgunTarihi.Value,
                OgunAdi = cmbOgunSecme.SelectedIndex.ToString()
            });
            txtSecilenUrunAdi.Clear();
            txtSecilenUrunPorsiyon.Clear();
            dgwGidalar.DataSource = null;
            dgwGidalar.DataSource = _gidaService.GetAll();
            dgwSecilenler.DataSource = null;
            dgwSecilenler.DataSource = secilenGidalar;
        }


        private void btnSecilenleriKaydet_Click(object sender, EventArgs e)
        {
            if (secilenGidalar != null)
            {
                var OgunVm = new OgunCreateVm
                {
                    Ad = cmbOgunSecme.SelectedIndex.ToString(),
                    KullaniciID = _kullaniciId,
                    OlusturulmaTarihi = dtpOgunTarihi.Value,
                    Yemekler = secilenGidalar.Cast<Gida>().ToList()

                };
                _ogunService.Create(OgunVm);
                MessageBox.Show("Create islemi basarili!");
                secilenGidalar.Clear();
                dgwSecilenler.DataSource = null;
            }

        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            SorguTemizle();
        }

        private void btnRaporlarSayfasi_Click_1(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar(_kullaniciId);
            raporlar.ShowDialog();
        }

        private void dgwDetaylar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SorguButonlariniKapat();
            DetayButonlariniAc();
            SorguTemizle();
        }

        private void SorguTemizle()
        {
            txtAramaMetni.Clear();
            cmbOgunSecme.SelectedIndex = -1;
            dtpOgunTarihi.Value = DateTime.Now;
            txtSecilenUrunAdi.Clear();
            txtSecilenUrunPorsiyon.Clear();
            secilenGidalar.Clear();
            dgwGidalar.DataSource = _gidaService.GetAll();
            lblSecilenKalorisi.Text = "";
        }

        private void DetayButonlariniAc()
        {
            btnEkle.Enabled = true;
            btnListele.Enabled = true;
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
        }

        private void DetayButonlariniKapat()
        {
            btnEkle.Enabled = false;
            btnListele.Enabled = false;
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
        }


        private void SorguButonlariniAc()
        {
            txtAramaMetni.Enabled = true;
            btnSec.Enabled = true;
            btnTemizle.Enabled = true;
            btnSecilenleriKaydet.Enabled = true;
        }

        private void SorguButonlariniKapat()
        {
            txtAramaMetni.Enabled = false;
            btnSec.Enabled = false;
            btnTemizle.Enabled = false;
            btnSecilenleriKaydet.Enabled = false;
        }

        private void txtSecilenUrunPorsiyon_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSecilenUrunPorsiyon.Text, out decimal porsiyon))
            {
                decimal kalori = porsiyon * (decimal)dgwGidalar.CurrentRow.Cells["Kalori"].Value;
                lblSecilenKalorisi.Text = $" {kalori} kalori";
            }
            else
            {
                lblSecilenKalorisi.Text = "Geçersiz porsiyon değeri";
            }

        }

        private void dtpDetayTarih_ValueChanged(object sender, EventArgs e)
        {
            dgwDetaylar.DataSource = _ogunService.TarihtekiOgunuGoster(dtpDetayTarih.Value, _kullaniciId);
        }
    }
}
