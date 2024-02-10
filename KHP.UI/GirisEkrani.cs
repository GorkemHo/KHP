using KHP.Bll.IServices;
using KHP.Bll.Services;
using KHP.Entities;

namespace KHP.UI
{
    public partial class GirisEkrani : Form
    {
        IKullaniciService _service;
        public GirisEkrani()
        {
            InitializeComponent();
            _service = new KullaniciService();
        }

        private void lblKayýtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlma frm = new KayitOlma();
            frm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (TextBoxlarBosMu(txtEposta, txtSifre))
            {
                string kullaniciAdi = txtEposta.Text;
                string sifre = _service.sha256(txtSifre.Text);
                bool sonuc = _service.Authanticator(kullaniciAdi, sifre);
                Kullanici kullanici = _service.GetByUsername(kullaniciAdi);

                if (sonuc)
                {
                    AnaMenu ana = new AnaMenu(kullanici.ID);
                    ana.Show();
                    MessageBox.Show("Giriþ Baþarýlý");
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen boþ alan býrakmayýnýz.");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txtSifre.UseSystemPasswordChar == true)
            {
                txtSifre.UseSystemPasswordChar = false;
                chkSifreGoster.Text = "Gizle";
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                chkSifreGoster.Text = "Göster";
            }
        }
    }
}
