namespace _1_kelime_1_islem
{
    partial class Form_islem
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
            this.btn_islem_yenioyun = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSayilar = new System.Windows.Forms.Label();
            this.lblHedefSayi = new System.Windows.Forms.Label();
            this.grpSayiButonlari = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.listislemGecmisi = new System.Windows.Forms.ListBox();
            this.grpAritmetik = new System.Windows.Forms.GroupBox();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnEsit = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnSayiSec = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.grpSayiSec = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.grpKontrol = new System.Windows.Forms.GroupBox();
            this.btnOtoHesapla = new System.Windows.Forms.Button();
            this.lblToplamPuan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSayiButonlari.SuspendLayout();
            this.grpAritmetik.SuspendLayout();
            this.grpSayiSec.SuspendLayout();
            this.grpKontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_islem_yenioyun
            // 
            this.btn_islem_yenioyun.Location = new System.Drawing.Point(14, 23);
            this.btn_islem_yenioyun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_islem_yenioyun.Name = "btn_islem_yenioyun";
            this.btn_islem_yenioyun.Size = new System.Drawing.Size(112, 35);
            this.btn_islem_yenioyun.TabIndex = 0;
            this.btn_islem_yenioyun.Text = "Yeni Oyun";
            this.btn_islem_yenioyun.UseVisualStyleBackColor = true;
            this.btn_islem_yenioyun.Click += new System.EventHandler(this.btn_islem_yenioyun_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(14, 110);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(198, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanılıcak Sayılar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(248, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hedef Sayı:";
            // 
            // lblSayilar
            // 
            this.lblSayilar.AutoSize = true;
            this.lblSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayilar.ForeColor = System.Drawing.Color.Red;
            this.lblSayilar.Location = new System.Drawing.Point(343, 74);
            this.lblSayilar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSayilar.Name = "lblSayilar";
            this.lblSayilar.Size = new System.Drawing.Size(24, 20);
            this.lblSayilar.TabIndex = 4;
            this.lblSayilar.Text = "...";
            // 
            // lblHedefSayi
            // 
            this.lblHedefSayi.AutoSize = true;
            this.lblHedefSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHedefSayi.ForeColor = System.Drawing.Color.Red;
            this.lblHedefSayi.Location = new System.Drawing.Point(343, 117);
            this.lblHedefSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHedefSayi.Name = "lblHedefSayi";
            this.lblHedefSayi.Size = new System.Drawing.Size(24, 20);
            this.lblHedefSayi.TabIndex = 5;
            this.lblHedefSayi.Text = "...";
            // 
            // grpSayiButonlari
            // 
            this.grpSayiButonlari.Controls.Add(this.label5);
            this.grpSayiButonlari.Controls.Add(this.txtDisplay);
            this.grpSayiButonlari.Controls.Add(this.listislemGecmisi);
            this.grpSayiButonlari.Location = new System.Drawing.Point(18, 240);
            this.grpSayiButonlari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSayiButonlari.Name = "grpSayiButonlari";
            this.grpSayiButonlari.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSayiButonlari.Size = new System.Drawing.Size(518, 144);
            this.grpSayiButonlari.TabIndex = 6;
            this.grpSayiButonlari.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "İşlem Ekranı:";
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDisplay.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.Lime;
            this.txtDisplay.Location = new System.Drawing.Point(118, 94);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(272, 40);
            this.txtDisplay.TabIndex = 8;
            // 
            // listislemGecmisi
            // 
            this.listislemGecmisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listislemGecmisi.FormattingEnabled = true;
            this.listislemGecmisi.ItemHeight = 20;
            this.listislemGecmisi.Location = new System.Drawing.Point(403, 13);
            this.listislemGecmisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listislemGecmisi.Name = "listislemGecmisi";
            this.listislemGecmisi.Size = new System.Drawing.Size(107, 124);
            this.listislemGecmisi.TabIndex = 18;
            // 
            // grpAritmetik
            // 
            this.grpAritmetik.Controls.Add(this.btnClr);
            this.grpAritmetik.Controls.Add(this.btnEsit);
            this.grpAritmetik.Controls.Add(this.btnOnayla);
            this.grpAritmetik.Controls.Add(this.btnBol);
            this.grpAritmetik.Controls.Add(this.btnCarp);
            this.grpAritmetik.Controls.Add(this.btnCikar);
            this.grpAritmetik.Controls.Add(this.btnTopla);
            this.grpAritmetik.Location = new System.Drawing.Point(18, 387);
            this.grpAritmetik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAritmetik.Name = "grpAritmetik";
            this.grpAritmetik.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAritmetik.Size = new System.Drawing.Size(518, 135);
            this.grpAritmetik.TabIndex = 7;
            this.grpAritmetik.TabStop = false;
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClr.Location = new System.Drawing.Point(312, 25);
            this.btnClr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(68, 94);
            this.btnClr.TabIndex = 5;
            this.btnClr.Text = "CLR";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnEsit
            // 
            this.btnEsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEsit.Location = new System.Drawing.Point(223, 26);
            this.btnEsit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEsit.Name = "btnEsit";
            this.btnEsit.Size = new System.Drawing.Size(70, 94);
            this.btnEsit.TabIndex = 4;
            this.btnEsit.Text = "=";
            this.btnEsit.UseVisualStyleBackColor = true;
            this.btnEsit.Click += new System.EventHandler(this.btnEsit_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOnayla.Enabled = false;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(403, 25);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(107, 94);
            this.btnOnayla.TabIndex = 9;
            this.btnOnayla.Text = "Sonucu Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnBol
            // 
            this.btnBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBol.Location = new System.Drawing.Point(118, 82);
            this.btnBol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(77, 38);
            this.btnBol.TabIndex = 3;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.islemBut_click);
            // 
            // btnCarp
            // 
            this.btnCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarp.Location = new System.Drawing.Point(118, 26);
            this.btnCarp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(77, 38);
            this.btnCarp.TabIndex = 2;
            this.btnCarp.Text = "x";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.islemBut_click);
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Location = new System.Drawing.Point(21, 82);
            this.btnCikar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(77, 38);
            this.btnCikar.TabIndex = 1;
            this.btnCikar.Text = "-";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.islemBut_click);
            // 
            // btnTopla
            // 
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(21, 26);
            this.btnTopla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(77, 38);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.islemBut_click);
            // 
            // btnSayiSec
            // 
            this.btnSayiSec.Location = new System.Drawing.Point(14, 67);
            this.btnSayiSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSayiSec.Name = "btnSayiSec";
            this.btnSayiSec.Size = new System.Drawing.Size(112, 35);
            this.btnSayiSec.TabIndex = 10;
            this.btnSayiSec.Text = "Sayı Seç";
            this.btnSayiSec.UseVisualStyleBackColor = true;
            this.btnSayiSec.Click += new System.EventHandler(this.btnSayiSec_Click);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(432, 15);
            this.btnSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(79, 38);
            this.btnSec.TabIndex = 6;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // grpSayiSec
            // 
            this.grpSayiSec.Controls.Add(this.label3);
            this.grpSayiSec.Controls.Add(this.txt5);
            this.grpSayiSec.Controls.Add(this.btnSec);
            this.grpSayiSec.Controls.Add(this.txt1);
            this.grpSayiSec.Controls.Add(this.txt2);
            this.grpSayiSec.Controls.Add(this.txt3);
            this.grpSayiSec.Controls.Add(this.txt4);
            this.grpSayiSec.Controls.Add(this.txt6);
            this.grpSayiSec.Location = new System.Drawing.Point(18, 177);
            this.grpSayiSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSayiSec.Name = "grpSayiSec";
            this.grpSayiSec.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSayiSec.Size = new System.Drawing.Size(518, 60);
            this.grpSayiSec.TabIndex = 17;
            this.grpSayiSec.TabStop = false;
            this.grpSayiSec.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "x10";
            // 
            // txt5
            // 
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt5.Location = new System.Drawing.Point(265, 21);
            this.txt5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt5.MaxLength = 1;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(60, 26);
            this.txt5.TabIndex = 4;
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt1.Location = new System.Drawing.Point(5, 21);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt1.MaxLength = 1;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(60, 26);
            this.txt1.TabIndex = 0;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2.Location = new System.Drawing.Point(70, 21);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt2.MaxLength = 1;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(60, 26);
            this.txt2.TabIndex = 1;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt3.Location = new System.Drawing.Point(135, 21);
            this.txt3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt3.MaxLength = 1;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(60, 26);
            this.txt3.TabIndex = 2;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt4.Location = new System.Drawing.Point(200, 21);
            this.txt4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt4.MaxLength = 1;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(60, 26);
            this.txt4.TabIndex = 3;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt6
            // 
            this.txt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt6.Location = new System.Drawing.Point(330, 21);
            this.txt6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt6.MaxLength = 1;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(60, 26);
            this.txt6.TabIndex = 5;
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // grpKontrol
            // 
            this.grpKontrol.Controls.Add(this.btnOtoHesapla);
            this.grpKontrol.Controls.Add(this.lblToplamPuan);
            this.grpKontrol.Controls.Add(this.label4);
            this.grpKontrol.Controls.Add(this.btn_islem_yenioyun);
            this.grpKontrol.Controls.Add(this.btnReset);
            this.grpKontrol.Controls.Add(this.btnSayiSec);
            this.grpKontrol.Controls.Add(this.label1);
            this.grpKontrol.Controls.Add(this.label2);
            this.grpKontrol.Controls.Add(this.lblSayilar);
            this.grpKontrol.Controls.Add(this.lblHedefSayi);
            this.grpKontrol.Location = new System.Drawing.Point(18, 11);
            this.grpKontrol.Name = "grpKontrol";
            this.grpKontrol.Size = new System.Drawing.Size(518, 158);
            this.grpKontrol.TabIndex = 0;
            this.grpKontrol.TabStop = false;
            // 
            // btnOtoHesapla
            // 
            this.btnOtoHesapla.Location = new System.Drawing.Point(128, 111);
            this.btnOtoHesapla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOtoHesapla.Name = "btnOtoHesapla";
            this.btnOtoHesapla.Size = new System.Drawing.Size(112, 35);
            this.btnOtoHesapla.TabIndex = 19;
            this.btnOtoHesapla.Text = "Oto. Hesapla";
            this.btnOtoHesapla.UseVisualStyleBackColor = true;
            this.btnOtoHesapla.Click += new System.EventHandler(this.btnOtoHesapla_Click);
            // 
            // lblToplamPuan
            // 
            this.lblToplamPuan.AutoSize = true;
            this.lblToplamPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamPuan.ForeColor = System.Drawing.Color.Red;
            this.lblToplamPuan.Location = new System.Drawing.Point(343, 30);
            this.lblToplamPuan.Name = "lblToplamPuan";
            this.lblToplamPuan.Size = new System.Drawing.Size(24, 20);
            this.lblToplamPuan.TabIndex = 18;
            this.lblToplamPuan.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Toplam Puan:";
            // 
            // Form_islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 527);
            this.Controls.Add(this.grpKontrol);
            this.Controls.Add(this.grpSayiSec);
            this.Controls.Add(this.grpAritmetik);
            this.Controls.Add(this.grpSayiButonlari);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_islem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1 İŞLEM";
            this.grpSayiButonlari.ResumeLayout(false);
            this.grpSayiButonlari.PerformLayout();
            this.grpAritmetik.ResumeLayout(false);
            this.grpSayiSec.ResumeLayout(false);
            this.grpSayiSec.PerformLayout();
            this.grpKontrol.ResumeLayout(false);
            this.grpKontrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_islem_yenioyun;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSayilar;
        private System.Windows.Forms.Label lblHedefSayi;
        private System.Windows.Forms.GroupBox grpSayiButonlari;
        private System.Windows.Forms.GroupBox grpAritmetik;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnEsit;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnSayiSec;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.GroupBox grpSayiSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listislemGecmisi;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.GroupBox grpKontrol;
        private System.Windows.Forms.Label lblToplamPuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOtoHesapla;
    }
}