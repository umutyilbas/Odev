namespace WFA_McAdan
{
    partial class AdminForm
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
            this.lstEklenenHamburger = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHamburgerAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnHamburgerEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbHamburgerAdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYeniFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExtraAd = new System.Windows.Forms.TextBox();
            this.txtEkstraFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            this.btnHamburgerGecis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEklenenHamburger
            // 
            this.lstEklenenHamburger.FormattingEnabled = true;
            this.lstEklenenHamburger.ItemHeight = 16;
            this.lstEklenenHamburger.Location = new System.Drawing.Point(286, 22);
            this.lstEklenenHamburger.Name = "lstEklenenHamburger";
            this.lstEklenenHamburger.Size = new System.Drawing.Size(493, 308);
            this.lstEklenenHamburger.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hamburger Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat:";
            // 
            // txtHamburgerAdi
            // 
            this.txtHamburgerAdi.Location = new System.Drawing.Point(114, 64);
            this.txtHamburgerAdi.Name = "txtHamburgerAdi";
            this.txtHamburgerAdi.Size = new System.Drawing.Size(166, 23);
            this.txtHamburgerAdi.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(114, 98);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(166, 23);
            this.txtFiyat.TabIndex = 2;
            // 
            // btnHamburgerEkle
            // 
            this.btnHamburgerEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHamburgerEkle.Location = new System.Drawing.Point(114, 127);
            this.btnHamburgerEkle.Name = "btnHamburgerEkle";
            this.btnHamburgerEkle.Size = new System.Drawing.Size(166, 36);
            this.btnHamburgerEkle.TabIndex = 3;
            this.btnHamburgerEkle.Text = "HAMBURGER EKLE";
            this.btnHamburgerEkle.UseVisualStyleBackColor = true;
            this.btnHamburgerEkle.Click += new System.EventHandler(this.btnHamburgerEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYeniFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbHamburgerAdi);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.txtHamburgerAdi);
            this.groupBox1.Controls.Add(this.lstEklenenHamburger);
            this.groupBox1.Controls.Add(this.btnHamburgerEkle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 341);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hamburger Panel";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(114, 273);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(166, 32);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbHamburgerAdi
            // 
            this.cmbHamburgerAdi.FormattingEnabled = true;
            this.cmbHamburgerAdi.Location = new System.Drawing.Point(114, 214);
            this.cmbHamburgerAdi.Name = "cmbHamburgerAdi";
            this.cmbHamburgerAdi.Size = new System.Drawing.Size(166, 24);
            this.cmbHamburgerAdi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "HAMBURGER EKLE";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(111, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "HAMBURGER GÜNCELLE\r\n\r\n";
            // 
            // txtYeniFiyat
            // 
            this.txtYeniFiyat.Location = new System.Drawing.Point(114, 244);
            this.txtYeniFiyat.Name = "txtYeniFiyat";
            this.txtYeniFiyat.Size = new System.Drawing.Size(166, 23);
            this.txtYeniFiyat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hamburger Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yeni Fiyat:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEkstraEkle);
            this.groupBox2.Controls.Add(this.txtEkstraFiyat);
            this.groupBox2.Controls.Add(this.txtExtraAd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 164);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekstra Panel";
            // 
            // txtExtraAd
            // 
            this.txtExtraAd.Location = new System.Drawing.Point(114, 35);
            this.txtExtraAd.Name = "txtExtraAd";
            this.txtExtraAd.Size = new System.Drawing.Size(166, 23);
            this.txtExtraAd.TabIndex = 2;
            // 
            // txtEkstraFiyat
            // 
            this.txtEkstraFiyat.Location = new System.Drawing.Point(114, 67);
            this.txtEkstraFiyat.Name = "txtEkstraFiyat";
            this.txtEkstraFiyat.Size = new System.Drawing.Size(166, 23);
            this.txtEkstraFiyat.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ekstra Ad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fiyat:";
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.Location = new System.Drawing.Point(114, 96);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(166, 32);
            this.btnEkstraEkle.TabIndex = 3;
            this.btnEkstraEkle.Text = "Ekstra Ekle";
            this.btnEkstraEkle.UseVisualStyleBackColor = true;
            this.btnEkstraEkle.Click += new System.EventHandler(this.btnEkstraEkle_Click);
            // 
            // btnHamburgerGecis
            // 
            this.btnHamburgerGecis.Location = new System.Drawing.Point(577, 504);
            this.btnHamburgerGecis.Name = "btnHamburgerGecis";
            this.btnHamburgerGecis.Size = new System.Drawing.Size(220, 68);
            this.btnHamburgerGecis.TabIndex = 6;
            this.btnHamburgerGecis.Text = "Hamburger Paneline Geç";
            this.btnHamburgerGecis.UseVisualStyleBackColor = true;
            this.btnHamburgerGecis.Click += new System.EventHandler(this.btnHamburgerGecis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Seçili ürünü kaldır!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHamburgerGecis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEklenenHamburger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHamburgerAdi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnHamburgerEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtYeniFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHamburgerAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkstraEkle;
        private System.Windows.Forms.TextBox txtEkstraFiyat;
        private System.Windows.Forms.TextBox txtExtraAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHamburgerGecis;
        private System.Windows.Forms.Button button1;
    }
}