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
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            listView2 = new ListView();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 462);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView2);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(582, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 472);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(254, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(61, 107);
            button1.Name = "button1";
            button1.Size = new Size(111, 42);
            button1.TabIndex = 2;
            button1.Text = "Ogun Bazli Listele";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(307, 107);
            button2.Name = "button2";
            button2.Size = new Size(111, 42);
            button2.TabIndex = 3;
            button2.Text = "Kategori Bazli Listele";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(63, 168);
            listView1.Name = "listView1";
            listView1.Size = new Size(357, 97);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(61, 312);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(357, 94);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(25, 36);
            button3.Name = "button3";
            button3.Size = new Size(111, 42);
            button3.TabIndex = 0;
            button3.Text = "Ogunlere Gore Listele Azalan";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(230, 36);
            button4.Name = "button4";
            button4.Size = new Size(111, 42);
            button4.TabIndex = 1;
            button4.Text = "Yemeklere Gore Listele Azalan";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Location = new Point(25, 106);
            listView2.Name = "listView2";
            listView2.Size = new Size(316, 333);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 39);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 6;
            label2.Text = "Bitis Tarihi Seciniz";
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
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private ListView listView1;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private ListView listView2;
        private Button button4;
        private Button button3;
        private Label label2;
        private Label label1;
    }
}