namespace KHP.UI
{
    partial class AnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAramaMetni = new TextBox();
            cmbOgunSecme = new ComboBox();
            dtpOgunTarihi = new DateTimePicker();
            txtSecilenUrunAdi = new TextBox();
            txtSecilenUrunPorsiyon = new TextBox();
            lblSecilenKalorisi = new Label();
            btnSec = new Button();
            btnTemizle = new Button();
            btnSecilenleriKaydet = new Button();
            btnRaporlarSayfasi = new Button();
            lblToplamKalori = new Label();
            groupBox1 = new GroupBox();
            dgwDetaylar = new DataGridView();
            label9 = new Label();
            lblSecilenGunToplamKalori = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            dtpDetayTarih = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgwGidalar = new DataGridView();
            dgwSecilenler = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwGidalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwSecilenler).BeginInit();
            SuspendLayout();
            // 
            // txtAramaMetni
            // 
            txtAramaMetni.Location = new Point(104, 28);
            txtAramaMetni.Name = "txtAramaMetni";
            txtAramaMetni.Size = new Size(100, 23);
            txtAramaMetni.TabIndex = 0;
            txtAramaMetni.TextChanged += txtAramaMetni_TextChanged;
            // 
            // cmbOgunSecme
            // 
            cmbOgunSecme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgunSecme.FormattingEnabled = true;
            cmbOgunSecme.Items.AddRange(new object[] { "Kahvalti", "OglenYemegi", "AksamYemegi", "AraOgun" });
            cmbOgunSecme.Location = new Point(210, 279);
            cmbOgunSecme.Name = "cmbOgunSecme";
            cmbOgunSecme.Size = new Size(151, 23);
            cmbOgunSecme.TabIndex = 1;
            // 
            // dtpOgunTarihi
            // 
            dtpOgunTarihi.Location = new Point(367, 280);
            dtpOgunTarihi.Name = "dtpOgunTarihi";
            dtpOgunTarihi.Size = new Size(193, 23);
            dtpOgunTarihi.TabIndex = 2;
            // 
            // txtSecilenUrunAdi
            // 
            txtSecilenUrunAdi.Location = new Point(12, 279);
            txtSecilenUrunAdi.Name = "txtSecilenUrunAdi";
            txtSecilenUrunAdi.ReadOnly = true;
            txtSecilenUrunAdi.Size = new Size(100, 23);
            txtSecilenUrunAdi.TabIndex = 4;
            // 
            // txtSecilenUrunPorsiyon
            // 
            txtSecilenUrunPorsiyon.Location = new Point(116, 279);
            txtSecilenUrunPorsiyon.Name = "txtSecilenUrunPorsiyon";
            txtSecilenUrunPorsiyon.Size = new Size(88, 23);
            txtSecilenUrunPorsiyon.TabIndex = 4;
            txtSecilenUrunPorsiyon.TextChanged += txtSecilenUrunPorsiyon_TextChanged;
            // 
            // lblSecilenKalorisi
            // 
            lblSecilenKalorisi.BackColor = Color.Azure;
            lblSecilenKalorisi.BorderStyle = BorderStyle.FixedSingle;
            lblSecilenKalorisi.Location = new Point(576, 279);
            lblSecilenKalorisi.Name = "lblSecilenKalorisi";
            lblSecilenKalorisi.Size = new Size(82, 23);
            lblSecilenKalorisi.TabIndex = 5;
            // 
            // btnSec
            // 
            btnSec.BackColor = SystemColors.ControlLightLight;
            btnSec.ForeColor = SystemColors.WindowText;
            btnSec.Location = new Point(43, 331);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(583, 34);
            btnSec.TabIndex = 6;
            btnSec.Text = "GIDA BİLGİLERİNİ SEÇİLENLER LİSTESİNE EKLE";
            btnSec.UseVisualStyleBackColor = false;
            btnSec.Click += btnSec_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = SystemColors.ControlLightLight;
            btnTemizle.ForeColor = SystemColors.WindowText;
            btnTemizle.Location = new Point(45, 548);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(131, 40);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click_1;
            // 
            // btnSecilenleriKaydet
            // 
            btnSecilenleriKaydet.BackColor = SystemColors.ControlLightLight;
            btnSecilenleriKaydet.ForeColor = SystemColors.WindowText;
            btnSecilenleriKaydet.Location = new Point(331, 548);
            btnSecilenleriKaydet.Name = "btnSecilenleriKaydet";
            btnSecilenleriKaydet.Size = new Size(295, 40);
            btnSecilenleriKaydet.TabIndex = 8;
            btnSecilenleriKaydet.Text = "SEÇİLENLER LİSTESİNDEKİLERİ KAYDET";
            btnSecilenleriKaydet.UseVisualStyleBackColor = false;
            btnSecilenleriKaydet.Click += btnSecilenleriKaydet_Click;
            // 
            // btnRaporlarSayfasi
            // 
            btnRaporlarSayfasi.BackColor = SystemColors.ControlLightLight;
            btnRaporlarSayfasi.ForeColor = SystemColors.WindowText;
            btnRaporlarSayfasi.Location = new Point(837, 440);
            btnRaporlarSayfasi.Name = "btnRaporlarSayfasi";
            btnRaporlarSayfasi.Size = new Size(540, 40);
            btnRaporlarSayfasi.TabIndex = 9;
            btnRaporlarSayfasi.Text = "RAPORLAR SAYFASINI AÇ";
            btnRaporlarSayfasi.UseVisualStyleBackColor = false;
            btnRaporlarSayfasi.Click += btnRaporlarSayfasi_Click_1;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.BackColor = Color.Azure;
            lblToplamKalori.BorderStyle = BorderStyle.FixedSingle;
            lblToplamKalori.Location = new Point(182, 548);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(143, 40);
            lblToplamKalori.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgwDetaylar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblSecilenGunToplamKalori);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnListele);
            groupBox1.Controls.Add(dtpDetayTarih);
            groupBox1.Location = new Point(837, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 422);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarihe Göre Detaylar ";
            // 
            // dgwDetaylar
            // 
            dgwDetaylar.BackgroundColor = Color.LightCyan;
            dgwDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDetaylar.Location = new Point(6, 139);
            dgwDetaylar.MultiSelect = false;
            dgwDetaylar.Name = "dgwDetaylar";
            dgwDetaylar.ReadOnly = true;
            dgwDetaylar.RowTemplate.Height = 25;
            dgwDetaylar.Size = new Size(527, 180);
            dgwDetaylar.TabIndex = 18;
            dgwDetaylar.CellClick += dgwDetaylar_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 94);
            label9.Name = "label9";
            label9.Size = new Size(234, 15);
            label9.TabIndex = 7;
            label9.Text = "Detaylarını görmek istediğiniz tarihi seçiniz.";
            // 
            // lblSecilenGunToplamKalori
            // 
            lblSecilenGunToplamKalori.BackColor = Color.Azure;
            lblSecilenGunToplamKalori.BorderStyle = BorderStyle.FixedSingle;
            lblSecilenGunToplamKalori.Location = new Point(383, 94);
            lblSecilenGunToplamKalori.Name = "lblSecilenGunToplamKalori";
            lblSecilenGunToplamKalori.Size = new Size(104, 41);
            lblSecilenGunToplamKalori.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ControlLightLight;
            btnGuncelle.ForeColor = SystemColors.WindowText;
            btnGuncelle.Location = new Point(393, 354);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 39);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ControlLightLight;
            btnSil.ForeColor = SystemColors.WindowText;
            btnSil.Location = new Point(207, 352);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 39);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = SystemColors.ControlLightLight;
            btnListele.ForeColor = SystemColors.WindowText;
            btnListele.Location = new Point(7, 352);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(140, 39);
            btnListele.TabIndex = 3;
            btnListele.Text = "LİSTEYİ YENİLE";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // dtpDetayTarih
            // 
            dtpDetayTarih.Location = new Point(7, 112);
            dtpDetayTarih.Name = "dtpDetayTarih";
            dtpDetayTarih.Size = new Size(200, 23);
            dtpDetayTarih.TabIndex = 0;
            dtpDetayTarih.ValueChanged += dtpDetayTarih_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 31);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 12;
            label4.Text = "Gıda Arama : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 263);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 13;
            label5.Text = "Öğün Seç";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 262);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 14;
            label6.Text = "Tarih Seç";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 262);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 15;
            label7.Text = "Porsiyon Seç";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 262);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 16;
            label8.Text = "Seçilen Ürün";
            // 
            // dgwGidalar
            // 
            dgwGidalar.BackgroundColor = Color.LightCyan;
            dgwGidalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGidalar.Location = new Point(10, 57);
            dgwGidalar.MultiSelect = false;
            dgwGidalar.Name = "dgwGidalar";
            dgwGidalar.ReadOnly = true;
            dgwGidalar.RowTemplate.Height = 25;
            dgwGidalar.Size = new Size(648, 202);
            dgwGidalar.TabIndex = 17;
            dgwGidalar.CellClick += dgwGidalar_CellClick;
            // 
            // dgwSecilenler
            // 
            dgwSecilenler.BackgroundColor = Color.LightCyan;
            dgwSecilenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSecilenler.Location = new Point(44, 392);
            dgwSecilenler.MultiSelect = false;
            dgwSecilenler.Name = "dgwSecilenler";
            dgwSecilenler.ReadOnly = true;
            dgwSecilenler.RowTemplate.Height = 25;
            dgwSecilenler.Size = new Size(581, 150);
            dgwSecilenler.TabIndex = 18;
            dgwSecilenler.CellValueChanged += dgwSecilenler_CellValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 368);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 19;
            label1.Text = "SEÇİLENLER LİSTESİ :";
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1420, 619);
            Controls.Add(label1);
            Controls.Add(dgwSecilenler);
            Controls.Add(dgwGidalar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(lblToplamKalori);
            Controls.Add(btnRaporlarSayfasi);
            Controls.Add(btnSecilenleriKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(btnSec);
            Controls.Add(lblSecilenKalorisi);
            Controls.Add(txtSecilenUrunPorsiyon);
            Controls.Add(txtSecilenUrunAdi);
            Controls.Add(dtpOgunTarihi);
            Controls.Add(cmbOgunSecme);
            Controls.Add(txtAramaMetni);
            Name = "AnaMenu";
            Text = "AnaMenu";
            Load += AnaMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwGidalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwSecilenler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAramaMetni;
        private ComboBox cmbOgunSecme;
        private DateTimePicker dtpOgunTarihi;
        private TextBox txtSecilenUrunAdi;
        private TextBox txtSecilenUrunPorsiyon;
        private Label lblSecilenKalorisi;
        private Button btnSec;
        private Button btnTemizle;
        private Button btnSecilenleriKaydet;
        private Button btnRaporlarSayfasi;
        private Label lblToplamKalori;
        private GroupBox groupBox1;
        private Label lblSecilenGunToplamKalori;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private DateTimePicker dtpDetayTarih;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgwGidalar;
        private DataGridView dgwDetaylar;
        private DataGridView dgwSecilenler;
        private Label label1;
    }
}