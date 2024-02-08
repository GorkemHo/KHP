namespace KHP.UI
{
    partial class GirisEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblKayıtOl = new LinkLabel();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(111, 72);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(156, 23);
            txtEposta.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(111, 129);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(156, 23);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 75);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "E-Posta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 132);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // lblKayıtOl
            // 
            lblKayıtOl.AutoSize = true;
            lblKayıtOl.Location = new Point(162, 228);
            lblKayıtOl.Name = "lblKayıtOl";
            lblKayıtOl.Size = new Size(55, 15);
            lblKayıtOl.TabIndex = 4;
            lblKayıtOl.TabStop = true;
            lblKayıtOl.Text = "KAYIT OL";
            lblKayıtOl.LinkClicked += lblKayıtOl_LinkClicked;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Azure;
            btnGirisYap.Location = new Point(126, 176);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(127, 32);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(338, 336);
            Controls.Add(btnGirisYap);
            Controls.Add(lblKayıtOl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Name = "GirisEkrani";
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEposta;
        private TextBox txtSifre;
        private Label label1;
        private Label label2;
        private LinkLabel lblKayıtOl;
        private Button btnGirisYap;
    }
}
