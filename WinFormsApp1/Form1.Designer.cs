namespace WinFormsApp1
{
    partial class Form1
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
            this.comboBoxDersler = new System.Windows.Forms.ComboBox();
            this.print = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxVize = new System.Windows.Forms.TextBox();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.OrtalamaHespala = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOgrencino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDogum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxkimlikno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxdurumu = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.printList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxDersler
            // 
            this.comboBoxDersler.FormattingEnabled = true;
            this.comboBoxDersler.Location = new System.Drawing.Point(412, 172);
            this.comboBoxDersler.Name = "comboBoxDersler";
            this.comboBoxDersler.Size = new System.Drawing.Size(226, 28);
            this.comboBoxDersler.TabIndex = 0;
            this.comboBoxDersler.SelectedIndexChanged += new System.EventHandler(this.comboBoxDersler_SelectedIndexChanged);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(845, 425);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(227, 29);
            this.print.TabIndex = 1;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(28, 290);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(749, 164);
            this.listBox1.TabIndex = 2;
            // 
            // textBoxVize
            // 
            this.textBoxVize.Location = new System.Drawing.Point(846, 294);
            this.textBoxVize.Name = "textBoxVize";
            this.textBoxVize.Size = new System.Drawing.Size(227, 27);
            this.textBoxVize.TabIndex = 3;
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(845, 338);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(227, 27);
            this.textBoxFinal.TabIndex = 5;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(845, 380);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(109, 29);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Pouan Ekle";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // OrtalamaHespala
            // 
            this.OrtalamaHespala.Location = new System.Drawing.Point(960, 380);
            this.OrtalamaHespala.Name = "OrtalamaHespala";
            this.OrtalamaHespala.Size = new System.Drawing.Size(112, 29);
            this.OrtalamaHespala.TabIndex = 10;
            this.OrtalamaHespala.Text = "ORT hesapla";
            this.OrtalamaHespala.UseVisualStyleBackColor = true;
            this.OrtalamaHespala.Click += new System.EventHandler(this.OrtalamaHespala_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(226, 27);
            this.textBoxName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad*";
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(76, 119);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(226, 27);
            this.textBoxSoyadi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Soyadı*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(353, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bolum*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(364, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dersler*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(10, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(320, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Öğrencı No*";
            // 
            // textBoxOgrencino
            // 
            this.textBoxOgrencino.Location = new System.Drawing.Point(412, 122);
            this.textBoxOgrencino.Name = "textBoxOgrencino";
            this.textBoxOgrencino.Size = new System.Drawing.Size(226, 27);
            this.textBoxOgrencino.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(341, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Doğum*";
            // 
            // textBoxDogum
            // 
            this.textBoxDogum.Location = new System.Drawing.Point(412, 72);
            this.textBoxDogum.Name = "textBoxDogum";
            this.textBoxDogum.Size = new System.Drawing.Size(226, 27);
            this.textBoxDogum.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(794, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Vize";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(794, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(658, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Kimlik No*";
            // 
            // textBoxkimlikno
            // 
            this.textBoxkimlikno.Location = new System.Drawing.Point(744, 73);
            this.textBoxkimlikno.Name = "textBoxkimlikno";
            this.textBoxkimlikno.Size = new System.Drawing.Size(226, 27);
            this.textBoxkimlikno.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(670, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Durumu*";
            // 
            // comboBoxdurumu
            // 
            this.comboBoxdurumu.FormattingEnabled = true;
            this.comboBoxdurumu.Location = new System.Drawing.Point(744, 128);
            this.comboBoxdurumu.Name = "comboBoxdurumu";
            this.comboBoxdurumu.Size = new System.Drawing.Size(226, 28);
            this.comboBoxdurumu.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(10, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(335, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "* ile gösterilen alanların doldurulması zorunludur.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(692, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(744, 176);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(226, 27);
            this.textBoxEmail.TabIndex = 32;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 175);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 24);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ERKEK";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(161, 175);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 24);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "KADIN";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(794, 576);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Baskı sonucu";
            // 
            // printList
            // 
            this.printList.Enabled = false;
            this.printList.FormattingEnabled = true;
            this.printList.ItemHeight = 20;
            this.printList.Location = new System.Drawing.Point(28, 500);
            this.printList.Name = "printList";
            this.printList.Size = new System.Drawing.Size(749, 344);
            this.printList.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 1014);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.printList);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxdurumu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxkimlikno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxOgrencino);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDogum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSoyadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.OrtalamaHespala);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.textBoxVize);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.comboBoxDersler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxDersler;
        private Button print;
        private ListBox listBox1;
        private TextBox textBoxVize;
        private TextBox textBoxFinal;
        private Button ButtonAdd;
        private Button OrtalamaHespala;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxSoyadi;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxOgrencino;
        private Label label8;
        private TextBox textBoxDogum;
        private Label label9;
        private Label label10;
        private Label label2;
        private TextBox textBoxkimlikno;
        private Label label11;
        private ComboBox comboBoxdurumu;
        private Label label12;
        private Label label13;
        private TextBox textBoxEmail;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label14;
        private ListBox printList;
    }
}