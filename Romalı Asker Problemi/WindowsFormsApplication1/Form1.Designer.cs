namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbx_Kalanlar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbx_Olenler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbx_Askerler = new System.Windows.Forms.ListBox();
            this.btn_Goster = new System.Windows.Forms.Button();
            this.txt_AdimSayisi = new System.Windows.Forms.TextBox();
            this.txt_AskerSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbx_Kalanlar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbx_Olenler);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbx_Askerler);
            this.groupBox1.Controls.Add(this.btn_Goster);
            this.groupBox1.Controls.Add(this.txt_AdimSayisi);
            this.groupBox1.Controls.Add(this.txt_AskerSayisi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Romalı Asker Problemi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "İşlem Süresi";
            // 
            // lbx_Kalanlar
            // 
            this.lbx_Kalanlar.FormattingEnabled = true;
            this.lbx_Kalanlar.Location = new System.Drawing.Point(479, 51);
            this.lbx_Kalanlar.Name = "lbx_Kalanlar";
            this.lbx_Kalanlar.Size = new System.Drawing.Size(120, 147);
            this.lbx_Kalanlar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kalanlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ölenler";
            // 
            // lbx_Olenler
            // 
            this.lbx_Olenler.FormattingEnabled = true;
            this.lbx_Olenler.Location = new System.Drawing.Point(335, 51);
            this.lbx_Olenler.Name = "lbx_Olenler";
            this.lbx_Olenler.Size = new System.Drawing.Size(120, 147);
            this.lbx_Olenler.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Askerler";
            // 
            // lbx_Askerler
            // 
            this.lbx_Askerler.FormattingEnabled = true;
            this.lbx_Askerler.Location = new System.Drawing.Point(188, 51);
            this.lbx_Askerler.Name = "lbx_Askerler";
            this.lbx_Askerler.Size = new System.Drawing.Size(120, 147);
            this.lbx_Askerler.TabIndex = 5;
            // 
            // btn_Goster
            // 
            this.btn_Goster.Location = new System.Drawing.Point(91, 124);
            this.btn_Goster.Name = "btn_Goster";
            this.btn_Goster.Size = new System.Drawing.Size(75, 23);
            this.btn_Goster.TabIndex = 4;
            this.btn_Goster.Text = "Göster";
            this.btn_Goster.UseVisualStyleBackColor = true;
            this.btn_Goster.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_AdimSayisi
            // 
            this.txt_AdimSayisi.Location = new System.Drawing.Point(66, 84);
            this.txt_AdimSayisi.Name = "txt_AdimSayisi";
            this.txt_AdimSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_AdimSayisi.TabIndex = 3;
            this.txt_AdimSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AdimSayisi_KeyPress);
            // 
            // txt_AskerSayisi
            // 
            this.txt_AskerSayisi.Location = new System.Drawing.Point(66, 51);
            this.txt_AskerSayisi.Name = "txt_AskerSayisi";
            this.txt_AskerSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_AskerSayisi.TabIndex = 2;
            this.txt_AskerSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AskerSayisi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aralık:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asker:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.roman_soldier_transparent_background;
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 247);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbx_Askerler;
        private System.Windows.Forms.Button btn_Goster;
        private System.Windows.Forms.TextBox txt_AdimSayisi;
        private System.Windows.Forms.TextBox txt_AskerSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_Kalanlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbx_Olenler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

