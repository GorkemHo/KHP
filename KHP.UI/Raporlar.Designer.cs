namespace KHP.UI
{
    partial class Raporlar
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            dgvHerkes = new DataGridView();
            dgvKisi = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            btnKategoriBazliListele = new Button();
            btnOgunBazliListele = new Button();
            dtpBitis = new DateTimePicker();
            dtpBaslangic = new DateTimePicker();
            groupBox2 = new GroupBox();
            label4 = new Label();
            dgvFiltreliList = new DataGridView();
            btnYemeklereGoreListeleAzalan = new Button();
            btnOgunlereGoreListeleAzalan = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHerkes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKisi).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFiltreliList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dgvHerkes);
            groupBox1.Controls.Add(dgvKisi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnKategoriBazliListele);
            groupBox1.Controls.Add(btnOgunBazliListele);
            groupBox1.Controls.Add(dtpBitis);
            groupBox1.Controls.Add(dtpBaslangic);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 584);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Baz Raporlar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 152);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 7;
            label5.Text = "Kullanıcı Raporu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 347);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 9;
            label3.Text = "Tüm Kullanıcı Raporu";
            // 
            // dgvHerkes
            // 
            dgvHerkes.BackgroundColor = Color.LightCyan;
            dgvHerkes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHerkes.Location = new Point(6, 365);
            dgvHerkes.Name = "dgvHerkes";
            dgvHerkes.RowTemplate.Height = 25;
            dgvHerkes.Size = new Size(511, 213);
            dgvHerkes.TabIndex = 8;
            // 
            // dgvKisi
            // 
            dgvKisi.BackgroundColor = Color.LightCyan;
            dgvKisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKisi.Location = new Point(6, 171);
            dgvKisi.Name = "dgvKisi";
            dgvKisi.ReadOnly = true;
            dgvKisi.RowTemplate.Height = 25;
            dgvKisi.Size = new Size(511, 150);
            dgvKisi.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 39);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 6;
            label2.Text = "Bitis Tarihi Seciniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 6;
            label1.Text = "Baslangic Tarihi Seciniz";
            // 
            // btnKategoriBazliListele
            // 
            btnKategoriBazliListele.Location = new Point(283, 91);
            btnKategoriBazliListele.Name = "btnKategoriBazliListele";
            btnKategoriBazliListele.Size = new Size(136, 42);
            btnKategoriBazliListele.TabIndex = 3;
            btnKategoriBazliListele.Text = "Kategori Bazlı Listele";
            btnKategoriBazliListele.UseVisualStyleBackColor = true;
            btnKategoriBazliListele.Click += btnKategoriBazliListele_Click;
            // 
            // btnOgunBazliListele
            // 
            btnOgunBazliListele.Location = new Point(62, 91);
            btnOgunBazliListele.Name = "btnOgunBazliListele";
            btnOgunBazliListele.Size = new Size(142, 42);
            btnOgunBazliListele.TabIndex = 2;
            btnOgunBazliListele.Text = "Öğün Bazlı Listele";
            btnOgunBazliListele.UseVisualStyleBackColor = true;
            btnOgunBazliListele.Click += btnOgunBazliListele_Click;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(254, 57);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(200, 23);
            dtpBitis.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(21, 57);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(200, 23);
            dtpBaslangic.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dgvFiltreliList);
            groupBox2.Controls.Add(btnYemeklereGoreListeleAzalan);
            groupBox2.Controls.Add(btnOgunlereGoreListeleAzalan);
            groupBox2.Location = new Point(582, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 584);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtreli Raporlar";
            // 
            // label4
            // 
            label4.Location = new Point(6, 105);
            label4.Name = "label4";
            label4.Size = new Size(347, 42);
            label4.TabIndex = 7;
            label4.Text = "Yukarıdaki butonlara basarak verilerinizi aşağıdaki tabloda listeleyebilirsiniz.";
            // 
            // dgvFiltreliList
            // 
            dgvFiltreliList.BackgroundColor = Color.LightCyan;
            dgvFiltreliList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFiltreliList.Location = new Point(6, 171);
            dgvFiltreliList.Name = "dgvFiltreliList";
            dgvFiltreliList.RowTemplate.Height = 25;
            dgvFiltreliList.Size = new Size(347, 407);
            dgvFiltreliList.TabIndex = 2;
            // 
            // btnYemeklereGoreListeleAzalan
            // 
            btnYemeklereGoreListeleAzalan.Location = new Point(212, 36);
            btnYemeklereGoreListeleAzalan.Name = "btnYemeklereGoreListeleAzalan";
            btnYemeklereGoreListeleAzalan.Size = new Size(141, 42);
            btnYemeklereGoreListeleAzalan.TabIndex = 1;
            btnYemeklereGoreListeleAzalan.Text = "Gıdalara Göre Listele (Azalan Porsiyon)";
            btnYemeklereGoreListeleAzalan.UseVisualStyleBackColor = true;
            btnYemeklereGoreListeleAzalan.Click += btnYemeklereGoreListeleAzalan_Click;
            // 
            // btnOgunlereGoreListeleAzalan
            // 
            btnOgunlereGoreListeleAzalan.Location = new Point(6, 36);
            btnOgunlereGoreListeleAzalan.Name = "btnOgunlereGoreListeleAzalan";
            btnOgunlereGoreListeleAzalan.Size = new Size(146, 42);
            btnOgunlereGoreListeleAzalan.TabIndex = 0;
            btnOgunlereGoreListeleAzalan.Text = "Öğünlere Göre Listele (Azalan Porsiyon)";
            btnOgunlereGoreListeleAzalan.UseVisualStyleBackColor = true;
            btnOgunlereGoreListeleAzalan.Click += btnOgunlereGoreListeleAzalan_Click;
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(966, 666);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Raporlar";
            Text = "Raporlar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHerkes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKisi).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFiltreliList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnKategoriBazliListele;
        private Button btnOgunBazliListele;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBaslangic;
        private GroupBox groupBox2;
        private Button btnYemeklereGoreListeleAzalan;
        private Button btnOgunlereGoreListeleAzalan;
        private Label label2;
        private Label label1;
        private DataGridView dgvHerkes;
        private DataGridView dgvKisi;
        private DataGridView dgvFiltreliList;
        private Label label5;
        private Label label3;
        private Label label4;
    }
}