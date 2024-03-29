﻿using KHP.Bll.IServices;
using KHP.Bll.Services;
using KHP.Entities;
using KHP.ViewModels.GidaVms;
using KHP.ViewModels.KullaniciGidaVms;
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
        IKullaniciGidaService _kullaniciGidaService;
        IGidaService _gidaService;
        int _kullaniciId;
        List<GidaEklemeVm> secilenGidalar;


        public AnaMenu(int kullaniciId)
        {
            InitializeComponent();
            _gidaService = new GidaService();
            _kullaniciId = kullaniciId;
            secilenGidalar = new List<GidaEklemeVm>();
            _kullaniciGidaService = new KullaniciGidaService();
        }
        private void AnaMenu_Load(object sender, EventArgs e)
        {
            dgwGidalar.DataSource = _gidaService.GetAll();              
            SorguButonlariniKapat();
            DetayButonlariniKapat();
            txtAramaMetni.Enabled = true;
            cmbOgunSecme.SelectedIndex = 0;
            dgwGidalar.CurrentCell = null;
        }

        private void txtAramaMetni_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtAramaMetni.Text;

            if (!string.IsNullOrEmpty(aramaMetni))
            {
                List<GidaListVm> arananGidalar = _gidaService.GetAll().Where(gida => gida.Ad.ToLower().Contains(aramaMetni.ToLower())).ToList();
                dgwGidalar.DataSource = arananGidalar;
            }
            else
            {
                dgwGidalar.DataSource = _gidaService.GetAll();
            }
        }

        private void dgwGidalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SorguButonlariniAc();
            DetayButonlariniKapat();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgwGidalar.Rows[e.RowIndex];

                txtSecilenUrunAdi.Text = selectedRow.Cells["Ad"].Value.ToString();
                txtSecilenUrunPorsiyon.Text = selectedRow.Cells["Porsiyon"].Value.ToString();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {            
            try
            {
                if (decimal.TryParse(txtSecilenUrunPorsiyon.Text, out decimal porsiyon) && porsiyon > 0)
                {
                    secilenGidalar.Add(new GidaEklemeVm
                    {
                        Id = _kullaniciId,
                        GidaAdi = txtSecilenUrunAdi.Text,
                        Porsiyon = Convert.ToDecimal(txtSecilenUrunPorsiyon.Text),
                        Kalori = Convert.ToDecimal(txtSecilenUrunPorsiyon.Text) * (decimal)dgwGidalar.CurrentRow.Cells["Kalori"].Value,
                        GidaTuru = (string)dgwGidalar.CurrentRow.Cells["GidaTuru"].Value,
                        OlusturulmaTarihi = dtpOgunTarihi.Value,
                        OgunAdi = cmbOgunSecme.SelectedItem.ToString()
                    });
                    SecilenleriTemizle();                    
                    DataGridViewGuncelleSecilenler();
                }
                else
                {
                    MessageBox.Show("Geçersiz porsiyon değeri. Lütfen pozitif bir rakam giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Secme islemi sirasinda bir hata meydana geldi!");
            }
        }

        

        private void btnSecilenleriKaydet_Click(object sender, EventArgs e)
        {
            if (secilenGidalar != null)
            {

                foreach (var item in secilenGidalar)
                {
                    var kullaniciGida = new KullaniciGidaCreateVm
                    {
                        KullaniciId = item.Id,
                        OgunAdi = item.OgunAdi,
                        GidaAdi = item.GidaAdi,
                        Kalori = item.Kalori,
                        GidaTuru = item.GidaTuru,
                        Porsiyon = item.Porsiyon,
                        OlusturulmaTarihi = item.OlusturulmaTarihi
                    };
                    _kullaniciGidaService.Create(kullaniciGida);
                }
                MessageBox.Show("Kayit islemi basarili!");
                SorguTemizle();
                SorguButonlariniKapat();
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
            SorguTemizle();
            SorguButonlariniKapat();
            DetayButonlariniAc();

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgwDetaylar.Rows[e.RowIndex];

                    txtSecilenUrunAdi.Text = selectedRow.Cells["GidaAdi"].Value.ToString();
                    txtSecilenUrunPorsiyon.Text = selectedRow.Cells["Porsiyon"].Value.ToString();
                    cmbOgunSecme.SelectedItem = selectedRow.Cells["OgunAdi"].Value.ToString();
                    dtpOgunTarihi.Value = Convert.ToDateTime(selectedRow.Cells["OlusturulmaTarihi"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hucre secme sirasinda bir hata meydana geldi!");
            }            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwDetaylar.CurrentRow != null)
                {
                    if (decimal.TryParse(txtSecilenUrunPorsiyon.Text, out decimal porsiyon) && porsiyon > 0)
                    {
                        decimal carpanKalori = (decimal)dgwDetaylar.CurrentRow.Cells["Porsiyon"].Value;
                        var KullaniciGidaUpdate = new KullaniciGidaUpdateVm
                        {
                            Id = Convert.ToInt32(dgwDetaylar.CurrentRow.Cells["ID"].Value),
                            KullaniciId = _kullaniciId,
                            GidaAdi = txtSecilenUrunAdi.Text,
                            GidaTuru = dgwDetaylar.CurrentRow.Cells["GidaTuru"].Value.ToString(),
                            Porsiyon = Convert.ToDecimal(txtSecilenUrunPorsiyon.Text),
                            Kalori = Convert.ToDecimal(txtSecilenUrunPorsiyon.Text) * (decimal)dgwDetaylar.CurrentRow.Cells["Kalori"].Value / carpanKalori,
                            OgunAdi = Convert.ToString(cmbOgunSecme.SelectedItem),
                            OlusturulmaTarihi = dtpOgunTarihi.Value.Date
                        };
                        _kullaniciGidaService.Update(KullaniciGidaUpdate);
                        DetaylarTablosunuGuncelle();
                        MessageBox.Show("GÜNCELLEME TAMAMLANDI.");

                    }
                    else
                    {
                        MessageBox.Show("Geçersiz porsiyon değeri. Lütfen pozitif bir rakam giriniz.");
                    }                    
                }
                else
                {
                    MessageBox.Show("Gunceleme islemi icin detaylar tablosundan bir satir seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GUNCELLENIRKEN HATA!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwDetaylar.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgwDetaylar.CurrentRow.Cells["Id"].Value);
                    _kullaniciGidaService.Delete(id);
                    MessageBox.Show("Silindi.");
                    DetaylarTablosunuGuncelle();
                }
                else
                {
                    MessageBox.Show("Silme islemi icin detaylar tablosundan bir satir seciniz");
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("SİLİNİRKEN HATA!");
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DetaylarTablosunuGuncelle();                     
        }

        

        private void txtSecilenUrunPorsiyon_TextChanged(object sender, EventArgs e)
        {
            if(dgwGidalar.CurrentRow != null)
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
        }

        private void dgwSecilenler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewGuncelleSecilenler();
        }

        private void dtpDetayTarih_ValueChanged(object sender, EventArgs e)
        {
            dgwDetaylar.DataSource = null;
            dgwDetaylar.DataSource = _kullaniciGidaService.GetAll().Where(x => x.KullaniciId == _kullaniciId && x.OlusturulmaTarihi.Date == dtpDetayTarih.Value.Date).ToList();
            DataGridViewGuncelleDetay();
        }


        #region Metotlar

        private void DetaylarTablosunuGuncelle()
        {
            try
            {
                dgwDetaylar.DataSource = null;
                dgwDetaylar.DataSource = _kullaniciGidaService.GetAll().Where(x => x.KullaniciId == _kullaniciId && x.OlusturulmaTarihi.Date == dtpDetayTarih.Value.Date).ToList();
                DataGridViewGuncelleDetay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme islemi sirasinda hata olustu!");
            }
        }

        private void SecilenleriTemizle()
        {
            txtSecilenUrunAdi.Clear();
            txtSecilenUrunPorsiyon.Clear();
            dgwGidalar.DataSource = null;
            dgwGidalar.DataSource = _gidaService.GetAll();
            dgwSecilenler.DataSource = null;
            dgwSecilenler.DataSource = secilenGidalar;
            btnSecilenleriKaydet.Enabled = true;
            btnSec.Enabled = false;
            dgwGidalar.CurrentCell = null;
        }

        private void DataGridViewGuncelleDetay()
        {
            decimal toplamKalori = ToplamKaloriHesaplaSecilenGunIcin();
            lblSecilenGunToplamKalori.Text = $"Toplam Kalori: {toplamKalori} kalori";
        }

        private void SorguTemizle()
        {
            txtAramaMetni.Clear();
            cmbOgunSecme.SelectedIndex = 0;
            dtpOgunTarihi.Value = DateTime.Now;
            txtSecilenUrunAdi.Clear();
            txtSecilenUrunPorsiyon.Clear();
            secilenGidalar.Clear();
            dgwGidalar.DataSource = null;
            dgwGidalar.DataSource = _gidaService.GetAll();
            dgwGidalar.CurrentCell = null;
            lblSecilenKalorisi.Text = "";
            dgwSecilenler.DataSource = null;
            btnSecilenleriKaydet.Enabled = false;
            btnSec.Enabled = false;
            DataGridViewGuncelleSecilenler();
        }

        private decimal ToplamKaloriHesaplaSecilenGunIcin()
        {
            decimal toplamKalori = 0;

            foreach (DataGridViewRow row in dgwDetaylar.Rows)
            {
                if (row.Cells["Kalori"].Value != null && decimal.TryParse(row.Cells["Kalori"].Value.ToString(), out decimal kalori))
                {
                    toplamKalori += kalori;
                }
            }
            return toplamKalori;
        }

        private void DataGridViewGuncelleSecilenler()
        {
            decimal toplamKalori = ToplamKaloriHesaplaSecilenlerIcin();
            lblToplamKalori.Text = $"Toplam Kalori: {toplamKalori} kalori";
        }

        private decimal ToplamKaloriHesaplaSecilenlerIcin()
        {
            decimal toplamKalori = 0;

            foreach (DataGridViewRow row in dgwSecilenler.Rows)
            {
                if (row.Cells["Kalori"].Value != null && decimal.TryParse(row.Cells["Kalori"].Value.ToString(), out decimal kalori))
                {
                    toplamKalori += kalori;
                }
            }
            return toplamKalori;
        }

        private void DetayButonlariniAc()
        {
            btnListele.Enabled = true;
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
        }

        private void DetayButonlariniKapat()
        {
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
        }


        private void SorguButonlariniAc()
        {
            txtAramaMetni.Enabled = true;
            btnSec.Enabled = true;
            btnTemizle.Enabled = true;
        }

        private void SorguButonlariniKapat()
        {
            txtAramaMetni.Enabled = false;
            btnSec.Enabled = false;
            btnTemizle.Enabled = false;
            btnSecilenleriKaydet.Enabled = false;
        }
        #endregion



    }
}
