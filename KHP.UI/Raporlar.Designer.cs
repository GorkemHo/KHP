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
            dgvHerkes = new DataGridView();
            dgvKisi = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            btnKategoriBazliListele = new Button();
            btnOgunBazliListele = new Button();
            dtpBitis = new DateTimePicker();
            dtpBaslangic = new DateTimePicker();
            groupBox2 = new GroupBox();
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
            // dgvHerkes
            // 
            dgvHerkes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHerkes.Location = new Point(6, 365);
            dgvHerkes.Name = "dgvHerkes";
            dgvHerkes.RowTemplate.Height = 25;
            dgvHerkes.Size = new Size(511, 213);
            dgvHerkes.TabIndex = 8;
            // 
            // dgvKisi
            // 
            dgvKisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKisi.Location = new Point(6, 155);
            dgvKisi.Name = "dgvKisi";
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
            btnKategoriBazliListele.Location = new Point(289, 107);
            btnKategoriBazliListele.Name = "btnKategoriBazliListele";
            btnKategoriBazliListele.Size = new Size(129, 42);
            btnKategoriBazliListele.TabIndex = 3;
            btnKategoriBazliListele.Text = "Kategori Bazlı Listele";
            btnKategoriBazliListele.UseVisualStyleBackColor = true;
            btnKategoriBazliListele.Click += btnKategoriBazliListele_Click;
            // 
            // btnOgunBazliListele
            // 
            btnOgunBazliListele.Location = new Point(61, 107);
            btnOgunBazliListele.Name = "btnOgunBazliListele";
            btnOgunBazliListele.Size = new Size(111, 42);
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
            groupBox2.Controls.Add(dgvFiltreliList);
            groupBox2.Controls.Add(btnYemeklereGoreListeleAzalan);
            groupBox2.Controls.Add(btnOgunlereGoreListeleAzalan);
            groupBox2.Location = new Point(582, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 584);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtreli Raporlar";
            // 
            // dgvFiltreliList
            // 
            dgvFiltreliList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFiltreliList.Location = new Point(6, 107);
            dgvFiltreliList.Name = "dgvFiltreliList";
            dgvFiltreliList.RowTemplate.Height = 25;
            dgvFiltreliList.Size = new Size(379, 407);
            dgvFiltreliList.TabIndex = 2;
            // 
            // btnYemeklereGoreListeleAzalan
            // 
            btnYemeklereGoreListeleAzalan.Location = new Point(230, 36);
            btnYemeklereGoreListeleAzalan.Name = "btnYemeklereGoreListeleAzalan";
            btnYemeklereGoreListeleAzalan.Size = new Size(111, 42);
            btnYemeklereGoreListeleAzalan.TabIndex = 1;
            btnYemeklereGoreListeleAzalan.Text = "Yemeklere Göre Listele Azalan";
            btnYemeklereGoreListeleAzalan.UseVisualStyleBackColor = true;
            btnYemeklereGoreListeleAzalan.Click += btnYemeklereGoreListeleAzalan_Click;
            // 
            // btnOgunlereGoreListeleAzalan
            // 
            btnOgunlereGoreListeleAzalan.Location = new Point(25, 36);
            btnOgunlereGoreListeleAzalan.Name = "btnOgunlereGoreListeleAzalan";
            btnOgunlereGoreListeleAzalan.Size = new Size(111, 42);
            btnOgunlereGoreListeleAzalan.TabIndex = 0;
            btnOgunlereGoreListeleAzalan.Text = "Öğünlere Göre Listele Azalan";
            btnOgunlereGoreListeleAzalan.UseVisualStyleBackColor = true;
            btnOgunlereGoreListeleAzalan.Click += btnOgunlereGoreListeleAzalan_Click;
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 666);
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
    }
}