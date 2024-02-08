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


            if (TextBoxlarBosMu(txtAdı, txtSoyadı, txtSifre, txtTekrarSifre, txtEposta))
            {
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
                            MessageBox.Show("Kayıt Başarılı, Giriş yapabilirsiniz.");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre en az 2 büyük harf ve en az 3 küçük harf içermeli, 8 karakterden uzun olmalıdır.");
                    }
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı mevcut. Lütfen farklı bir kullanıcı adı giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }


        }
        private bool TextBoxlarBosMu(params TextBox[] textBoxlar)
        {
            foreach (TextBox textBox in textBoxlar)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
