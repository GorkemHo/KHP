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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwGidalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwSecilenler).BeginInit();
            SuspendLayout();
            // 
            // txtAramaMetni
            // 
            txtAramaMetni.Location = new Point(12, 102);
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
            cmbOgunSecme.Location = new Point(222, 300);
            cmbOgunSecme.Name = "cmbOgunSecme";
            cmbOgunSecme.Size = new Size(121, 23);
            cmbOgunSecme.TabIndex = 1;
            // 
            // dtpOgunTarihi
            // 
            dtpOgunTarihi.Location = new Point(347, 300);
            dtpOgunTarihi.Name = "dtpOgunTarihi";
            dtpOgunTarihi.Size = new Size(128, 23);
            dtpOgunTarihi.TabIndex = 2;
            // 
            // txtSecilenUrunAdi
            // 
            txtSecilenUrunAdi.Location = new Point(14, 300);
            txtSecilenUrunAdi.Name = "txtSecilenUrunAdi";
            txtSecilenUrunAdi.Size = new Size(100, 23);
            txtSecilenUrunAdi.TabIndex = 4;
            // 
            // txtSecilenUrunPorsiyon
            // 
            txtSecilenUrunPorsiyon.Location = new Point(118, 300);
            txtSecilenUrunPorsiyon.Name = "txtSecilenUrunPorsiyon";
            txtSecilenUrunPorsiyon.Size = new Size(100, 23);
            txtSecilenUrunPorsiyon.TabIndex = 4;
            txtSecilenUrunPorsiyon.TextChanged += txtSecilenUrunPorsiyon_TextChanged;
            // 
            // lblSecilenKalorisi
            // 
            lblSecilenKalorisi.BorderStyle = BorderStyle.FixedSingle;
            lblSecilenKalorisi.Location = new Point(206, 343);
            lblSecilenKalorisi.Name = "lblSecilenKalorisi";
            lblSecilenKalorisi.Size = new Size(76, 39);
            lblSecilenKalorisi.TabIndex = 5;
            // 
            // btnSec
            // 
            btnSec.Location = new Point(12, 400);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(464, 34);
            btnSec.TabIndex = 6;
            btnSec.Text = "SEC";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(14, 639);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(118, 40);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "TEMIZLE";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click_1;
            // 
            // btnSecilenleriKaydet
            // 
            btnSecilenleriKaydet.Location = new Point(180, 639);
            btnSecilenleriKaydet.Name = "btnSecilenleriKaydet";
            btnSecilenleriKaydet.Size = new Size(130, 40);
            btnSecilenleriKaydet.TabIndex = 8;
            btnSecilenleriKaydet.Text = "SECILENLERI KAYDET";
            btnSecilenleriKaydet.UseVisualStyleBackColor = true;
            btnSecilenleriKaydet.Click += btnSecilenleriKaydet_Click;
            // 
            // btnRaporlarSayfasi
            // 
            btnRaporlarSayfasi.Location = new Point(347, 637);
            btnRaporlarSayfasi.Name = "btnRaporlarSayfasi";
            btnRaporlarSayfasi.Size = new Size(106, 44);
            btnRaporlarSayfasi.TabIndex = 9;
            btnRaporlarSayfasi.Text = "RAPORLAR SAYFASI";
            btnRaporlarSayfasi.UseVisualStyleBackColor = true;
            btnRaporlarSayfasi.Click += btnRaporlarSayfasi_Click_1;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.BorderStyle = BorderStyle.FixedSingle;
            lblToplamKalori.Location = new Point(192, 593);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(106, 32);
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
            groupBox1.Location = new Point(648, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 399);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dgwDetaylar
            // 
            dgwDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDetaylar.Location = new Point(6, 139);
            dgwDetaylar.Name = "dgwDetaylar";
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
            label9.Size = new Size(231, 15);
            label9.TabIndex = 7;
            label9.Text = "Detaylarini gormek istediginiz tarihi seciniz";
            // 
            // lblSecilenGunToplamKalori
            // 
            lblSecilenGunToplamKalori.BorderStyle = BorderStyle.FixedSingle;
            lblSecilenGunToplamKalori.Location = new Point(383, 94);
            lblSecilenGunToplamKalori.Name = "lblSecilenGunToplamKalori";
            lblSecilenGunToplamKalori.Size = new Size(104, 41);
            lblSecilenGunToplamKalori.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(393, 354);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 39);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(207, 352);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 39);
            btnSil.TabIndex = 4;
            btnSil.Text = "SIL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(7, 352);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(140, 39);
            btnListele.TabIndex = 3;
            btnListele.Text = "LISTELE";
            btnListele.UseVisualStyleBackColor = true;
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
            label4.Location = new Point(13, 84);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Gida Arama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 284);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 13;
            label5.Text = "Ogun Secme";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 284);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 14;
            label6.Text = "Tarih";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 283);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 15;
            label7.Text = "Porsiyon";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 283);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 16;
            label8.Text = "Secilen Urun";
            // 
            // dgwGidalar
            // 
            dgwGidalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGidalar.Location = new Point(12, 131);
            dgwGidalar.Name = "dgwGidalar";
            dgwGidalar.RowTemplate.Height = 25;
            dgwGidalar.Size = new Size(464, 150);
            dgwGidalar.TabIndex = 17;
            dgwGidalar.CellClick += dgwGidalar_CellClick;
            // 
            // dgwSecilenler
            // 
            dgwSecilenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSecilenler.Location = new Point(14, 440);
            dgwSecilenler.Name = "dgwSecilenler";
            dgwSecilenler.RowTemplate.Height = 25;
            dgwSecilenler.Size = new Size(462, 150);
            dgwSecilenler.TabIndex = 18;
            dgwSecilenler.CellValueChanged += dgwSecilenler_CellValueChanged;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 814);
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
    }
}