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

        private void lblKay�tOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlma frm = new KayitOlma();
            frm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtEposta.Text;
            string sifre=_service.sha256(txtSifre.Text);
            bool sonuc=_service.Authanticator(kullaniciAdi, sifre);
            Kullanici kullanici = _service.GetByUsername(kullaniciAdi);
            
            if(sonuc)
            {
                AnaMenu ana= new AnaMenu(kullanici.ID);
                ana.Show();
                MessageBox.Show("Giris Basar�l�");
            }
            
            else
            {
                MessageBox.Show("Kullan�c� Ad� veya Sifre Hatal�!");
            }
        }
    }
}
