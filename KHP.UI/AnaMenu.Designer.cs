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
            listView1 = new ListView();
            dgwDetaylar = new DataGridView();
            label9 = new Label();
            label3 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            btnEkle = new Button();
            dtpDetayTarih = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgwGidalar = new DataGridView();
            dgwSecilenler = new DataGridView();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwGidalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwSecilenler).BeginInit();
            SuspendLayout();
            // 
            // txtAramaMetni
            // 
            txtAramaMetni.Location = new Point(61, 51);
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
            cmbOgunSecme.Location = new Point(61, 534);
            cmbOgunSecme.Name = "cmbOgunSecme";
            cmbOgunSecme.Size = new Size(121, 23);
            cmbOgunSecme.TabIndex = 1;
            // 
            // dtpOgunTarihi
            // 
            dtpOgunTarihi.Location = new Point(206, 534);
            dtpOgunTarihi.Name = "dtpOgunTarihi";
            dtpOgunTarihi.Size = new Size(128, 23);
            dtpOgunTarihi.TabIndex = 2;
            // 
            // txtSecilenUrunAdi
            // 
            txtSecilenUrunAdi.Location = new Point(62, 281);
            txtSecilenUrunAdi.Name = "txtSecilenUrunAdi";
            txtSecilenUrunAdi.Size = new Size(100, 23);
            txtSecilenUrunAdi.TabIndex = 4;
            // 
            // txtSecilenUrunPorsiyon
            // 
            txtSecilenUrunPorsiyon.Location = new Point(191, 281);
            txtSecilenUrunPorsiyon.Name = "txtSecilenUrunPorsiyon";
            txtSecilenUrunPorsiyon.Size = new Size(100, 23);
            txtSecilenUrunPorsiyon.TabIndex = 4;
            txtSecilenUrunPorsiyon.TextChanged += txtSecilenUrunPorsiyon_TextChanged;
            // 
            // lblSecilenKalorisi
            // 
            lblSecilenKalorisi.BorderStyle = BorderStyle.FixedSingle;
            lblSecilenKalorisi.Location = new Point(315, 257);
            lblSecilenKalorisi.Name = "lblSecilenKalorisi";
            lblSecilenKalorisi.Size = new Size(137, 47);
            lblSecilenKalorisi.TabIndex = 5;
            // 
            // btnSec
            // 
            btnSec.Location = new Point(63, 310);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(389, 34);
            btnSec.TabIndex = 6;
            btnSec.Text = "SEC";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(62, 573);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(163, 40);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "TEMIZLE";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click_1;
            // 
            // btnSecilenleriKaydet
            // 
            btnSecilenleriKaydet.Location = new Point(288, 573);
            btnSecilenleriKaydet.Name = "btnSecilenleriKaydet";
            btnSecilenleriKaydet.Size = new Size(164, 40);
            btnSecilenleriKaydet.TabIndex = 8;
            btnSecilenleriKaydet.Text = "SECILENLERI KAYDET";
            btnSecilenleriKaydet.UseVisualStyleBackColor = true;
            btnSecilenleriKaydet.Click += btnSecilenleriKaydet_Click;
            // 
            // btnRaporlarSayfasi
            // 
            btnRaporlarSayfasi.Location = new Point(155, 631);
            btnRaporlarSayfasi.Name = "btnRaporlarSayfasi";
            btnRaporlarSayfasi.Size = new Size(199, 44);
            btnRaporlarSayfasi.TabIndex = 9;
            btnRaporlarSayfasi.Text = "RAPORLAR SAYFASI";
            btnRaporlarSayfasi.UseVisualStyleBackColor = true;
            btnRaporlarSayfasi.Click += btnRaporlarSayfasi_Click_1;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Location = new Point(373, 537);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(79, 15);
            lblToplamKalori.TabIndex = 10;
            lblToplamKalori.Text = "Toplam Kalori";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(dgwDetaylar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnListele);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(dtpDetayTarih);
            groupBox1.Location = new Point(559, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 701);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // listView1
            // 
            listView1.Location = new Point(188, 327);
            listView1.Name = "listView1";
            listView1.Size = new Size(392, 139);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dgwDetaylar
            // 
            dgwDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDetaylar.Location = new Point(6, 68);
            dgwDetaylar.Name = "dgwDetaylar";
            dgwDetaylar.RowTemplate.Height = 25;
            dgwDetaylar.Size = new Size(574, 211);
            dgwDetaylar.TabIndex = 18;
            dgwDetaylar.CellClick += dgwDetaylar_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 21);
            label9.Name = "label9";
            label9.Size = new Size(231, 15);
            label9.TabIndex = 7;
            label9.Text = "Detaylarini gormek istediginiz tarihi seciniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 292);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 6;
            label3.Text = "Gunun toplam kalori bilgisi";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(7, 427);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(105, 39);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(7, 382);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(105, 39);
            btnSil.TabIndex = 4;
            btnSil.Text = "SIL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(7, 337);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(105, 39);
            btnListele.TabIndex = 3;
            btnListele.Text = "LISTELE";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(7, 292);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(105, 39);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dtpDetayTarih
            // 
            dtpDetayTarih.Location = new Point(7, 39);
            dtpDetayTarih.Name = "dtpDetayTarih";
            dtpDetayTarih.Size = new Size(200, 23);
            dtpDetayTarih.TabIndex = 0;
            dtpDetayTarih.ValueChanged += dtpDetayTarih_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 33);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Gida Arama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 516);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 13;
            label5.Text = "Ogun Secme";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 514);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 14;
            label6.Text = "Tarih";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 264);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 15;
            label7.Text = "Porsiyon";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 264);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 16;
            label8.Text = "Secilen Urun";
            // 
            // dgwGidalar
            // 
            dgwGidalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGidalar.Location = new Point(62, 80);
            dgwGidalar.Name = "dgwGidalar";
            dgwGidalar.RowTemplate.Height = 25;
            dgwGidalar.Size = new Size(390, 170);
            dgwGidalar.TabIndex = 17;
            dgwGidalar.CellClick += dgwGidalar_CellClick;
            // 
            // dgwSecilenler
            // 
            dgwSecilenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSecilenler.Location = new Point(61, 359);
            dgwSecilenler.Name = "dgwSecilenler";
            dgwSecilenler.RowTemplate.Height = 25;
            dgwSecilenler.Size = new Size(391, 150);
            dgwSecilenler.TabIndex = 18;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(142, 473);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(438, 124);
            listBox1.TabIndex = 20;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 725);
            Controls.Add(dgwSecilenler);
            Controls.Add(dgwGidalar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(lblToplamKalori);
            Controls.Add(btnRaporlarSayfasi);
            Controls.Add(btnSecilenleriKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(dtpOgunTarihi);
            Controls.Add(cmbOgunSecme);
            Controls.Add(btnSec);
            Controls.Add(lblSecilenKalorisi);
            Controls.Add(txtSecilenUrunPorsiyon);
            Controls.Add(txtSecilenUrunAdi);
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
        private Label label3;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private Button btnEkle;
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
        private ListView listView1;
        private ListBox listBox1;
    }
}