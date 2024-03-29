﻿namespace KHP.UI
{
    partial class KayitOlma
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
            txtAdı = new TextBox();
            txtSoyadı = new TextBox();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            txtTekrarSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            rdErkek = new RadioButton();
            rdKadın = new RadioButton();
            dtDogumTarıhı = new DateTimePicker();
            label7 = new Label();
            btnKayıtOl = new Button();
            SuspendLayout();
            // 
            // txtAdı
            // 
            txtAdı.Location = new Point(184, 55);
            txtAdı.Name = "txtAdı";
            txtAdı.Size = new Size(201, 23);
            txtAdı.TabIndex = 0;
            // 
            // txtSoyadı
            // 
            txtSoyadı.Location = new Point(184, 97);
            txtSoyadı.Name = "txtSoyadı";
            txtSoyadı.Size = new Size(201, 23);
            txtSoyadı.TabIndex = 1;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(184, 137);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(201, 23);
            txtEposta.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(184, 180);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(201, 23);
            txtSifre.TabIndex = 3;
            // 
            // txtTekrarSifre
            // 
            txtTekrarSifre.Location = new Point(184, 223);
            txtTekrarSifre.Name = "txtTekrarSifre";
            txtTekrarSifre.Size = new Size(201, 23);
            txtTekrarSifre.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 58);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 6;
            label1.Text = "Adınız :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 100);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Soyadınız :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 140);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "E-Posta :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 226);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 9;
            label4.Text = "Şifreyi Tekrar Giriniz :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 308);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 11;
            label6.Text = "Cinsiyetiniz :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 183);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Şifreniz :";
            // 
            // rdErkek
            // 
            rdErkek.AutoSize = true;
            rdErkek.Location = new Point(203, 308);
            rdErkek.Name = "rdErkek";
            rdErkek.Size = new Size(53, 19);
            rdErkek.TabIndex = 12;
            rdErkek.TabStop = true;
            rdErkek.Text = "Erkek";
            rdErkek.UseVisualStyleBackColor = true;
            // 
            // rdKadın
            // 
            rdKadın.AutoSize = true;
            rdKadın.Location = new Point(302, 308);
            rdKadın.Name = "rdKadın";
            rdKadın.Size = new Size(55, 19);
            rdKadın.TabIndex = 13;
            rdKadın.TabStop = true;
            rdKadın.Text = "Kadın";
            rdKadın.UseVisualStyleBackColor = true;
            // 
            // dtDogumTarıhı
            // 
            dtDogumTarıhı.Location = new Point(185, 268);
            dtDogumTarıhı.MaxDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
            dtDogumTarıhı.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtDogumTarıhı.Name = "dtDogumTarıhı";
            dtDogumTarıhı.Size = new Size(200, 23);
            dtDogumTarıhı.TabIndex = 14;
            dtDogumTarıhı.Value = new DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 269);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 11;
            label7.Text = "Doğum Tarihiniz :";
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.BackColor = Color.Azure;
            btnKayıtOl.Location = new Point(219, 345);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(109, 40);
            btnKayıtOl.TabIndex = 15;
            btnKayıtOl.Text = "KAYIT OL";
            btnKayıtOl.UseVisualStyleBackColor = false;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // KayitOlma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(451, 450);
            Controls.Add(btnKayıtOl);
            Controls.Add(dtDogumTarıhı);
            Controls.Add(rdKadın);
            Controls.Add(rdErkek);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTekrarSifre);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(txtSoyadı);
            Controls.Add(txtAdı);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "KayitOlma";
            Text = "KayitOlma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdı;
        private TextBox txtSoyadı;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private TextBox txtTekrarSifre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private RadioButton rdErkek;
        private RadioButton rdKadın;
        private DateTimePicker dtDogumTarıhı;
        private Label label7;
        private Button btnKayıtOl;
    }
}