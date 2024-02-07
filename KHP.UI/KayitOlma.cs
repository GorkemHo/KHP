using KHP.Bll.IServices;
using KHP.Bll.Services;
using KHP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHP.UI
{
    public partial class KayitOlma : Form
    {
        IKullaniciService _service;
        public KayitOlma()
        {
            InitializeComponent();
            _service = new KullaniciService();
        }





        private void btnKayıtOl_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = txtEposta.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string sifretekrar = txtTekrarSifre.Text.Trim();



            if (!_service.CheckIfUserNameExist(kullaniciAdi))
            {
                if (_service.CheckIfPasswordOk(sifre, sifretekrar))
                {
                    string hashlisifre = _service.sha256(sifre);
                    var createVm = new KullaniciCreateVm
                    {
                        Ad = txtAdı.Text,
                        Soyad = txtSoyadı.Text,
                        Eposta = txtEposta.Text,
                        Sifre = hashlisifre,

                        Cinsiyet = rdErkek.Checked ? true : false,
                        DogumTarihi = dtDogumTarıhı.Value
                    };
                    var result = _service.Create(createVm);
                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt Başarılı");
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Sifre kriterleri karşılamadıgı için kayıt başarısız!");
                }

            }
            else
            {
                MessageBox.Show("Bu kullanıcı mevcuttur");
            }




        }
    }
}
