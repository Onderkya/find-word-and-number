namespace _1_kelime_1_islem
{
    partial class Form_kelime
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
            this.lblHarfler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKelimeYenioyun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbJoker = new System.Windows.Forms.ComboBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnHarfSec = new System.Windows.Forms.Button();
            this.grpHarfSecimi = new System.Windows.Forms.GroupBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.grpKontrol = new System.Windows.Forms.GroupBox();
            this.btnOtoBul = new System.Windows.Forms.Button();
            this.lblToplamPuan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpKelime = new System.Windows.Forms.GroupBox();
            this.grpHarfSecimi.SuspendLayout();
            this.grpKontrol.SuspendLayout();
            this.grpKelime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHarfler
            // 
            this.lblHarfler.AutoSize = true;
            this.lblHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarfler.ForeColor = System.Drawing.Color.Red;
            this.lblHarfler.Location = new System.Drawing.Point(282, 74);
            this.lblHarfler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHarfler.Name = "lblHarfler";
            this.lblHarfler.Size = new System.Drawing.Size(24, 20);
            this.lblHarfler.TabIndex = 8;
            this.lblHarfler.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanılıcak Harfler:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(14, 110);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnKelimeYenioyun
            // 
            this.btnKelimeYenioyun.Location = new System.Drawing.Point(14, 23);
            this.btnKelimeYenioyun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKelimeYenioyun.Name = "btnKelimeYenioyun";
            this.btnKelimeYenioyun.Size = new System.Drawing.Size(112, 35);
            this.btnKelimeYenioyun.TabIndex = 5;
            this.btnKelimeYenioyun.Text = "Yeni Oyun";
            this.btnKelimeYenioyun.UseVisualStyleBackColor = true;
            this.btnKelimeYenioyun.Click += new System.EventHandler(this.btn_kelime_yenioyun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Türetilen Kelime:";
            // 
            // txtKelime
            // 
            this.txtKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKelime.Location = new System.Drawing.Point(160, 19);
            this.txtKelime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKelime.MaxLength = 9;
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(235, 26);
            this.txtKelime.TabIndex = 10;
            this.txtKelime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtKelime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Joker Harf:";
            // 
            // cmbJoker
            // 
            this.cmbJoker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoker.FormattingEnabled = true;
            this.cmbJoker.Location = new System.Drawing.Point(434, 114);
            this.cmbJoker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbJoker.Name = "cmbJoker";
            this.cmbJoker.Size = new System.Drawing.Size(55, 28);
            this.cmbJoker.TabIndex = 12;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Enabled = false;
            this.btnOnayla.Location = new System.Drawing.Point(406, 18);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(87, 28);
            this.btnOnayla.TabIndex = 13;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnHarfSec
            // 
            this.btnHarfSec.Location = new System.Drawing.Point(14, 67);
            this.btnHarfSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHarfSec.Name = "btnHarfSec";
            this.btnHarfSec.Size = new System.Drawing.Size(112, 35);
            this.btnHarfSec.TabIndex = 14;
            this.btnHarfSec.Text = "Harf Seç";
            this.btnHarfSec.UseVisualStyleBackColor = true;
            this.btnHarfSec.Click += new System.EventHandler(this.btnHarfSec_Click);
            // 
            // grpHarfSecimi
            // 
            this.grpHarfSecimi.Controls.Add(this.btnSec);
            this.grpHarfSecimi.Controls.Add(this.txt8);
            this.grpHarfSecimi.Controls.Add(this.txt7);
            this.grpHarfSecimi.Controls.Add(this.txt6);
            this.grpHarfSecimi.Controls.Add(this.txt5);
            this.grpHarfSecimi.Controls.Add(this.txt4);
            this.grpHarfSecimi.Controls.Add(this.txt3);
            this.grpHarfSecimi.Controls.Add(this.txt2);
            this.grpHarfSecimi.Controls.Add(this.txt1);
            this.grpHarfSecimi.Location = new System.Drawing.Point(20, 162);
            this.grpHarfSecimi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpHarfSecimi.Name = "grpHarfSecimi";
            this.grpHarfSecimi.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpHarfSecimi.Size = new System.Drawing.Size(504, 64);
            this.grpHarfSecimi.TabIndex = 15;
            this.grpHarfSecimi.TabStop = false;
            this.grpHarfSecimi.Visible = false;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(406, 22);
            this.btnSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(87, 27);
            this.btnSec.TabIndex = 24;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // txt8
            // 
            this.txt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt8.Location = new System.Drawing.Point(358, 23);
            this.txt8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt8.MaxLength = 1;
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(37, 26);
            this.txt8.TabIndex = 23;
            this.txt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt7
            // 
            this.txt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt7.Location = new System.Drawing.Point(309, 23);
            this.txt7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt7.MaxLength = 1;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(37, 26);
            this.txt7.TabIndex = 22;
            this.txt7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt6
            // 
            this.txt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt6.Location = new System.Drawing.Point(260, 23);
            this.txt6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt6.MaxLength = 1;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(37, 26);
            this.txt6.TabIndex = 21;
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt5
            // 
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt5.Location = new System.Drawing.Point(210, 23);
            this.txt5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt5.MaxLength = 1;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(37, 26);
            this.txt5.TabIndex = 20;
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt4.Location = new System.Drawing.Point(160, 23);
            this.txt4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt4.MaxLength = 1;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(37, 26);
            this.txt4.TabIndex = 19;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt3.Location = new System.Drawing.Point(111, 23);
            this.txt3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt3.MaxLength = 1;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(37, 26);
            this.txt3.TabIndex = 18;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2.Location = new System.Drawing.Point(62, 23);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt2.MaxLength = 1;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(37, 26);
            this.txt2.TabIndex = 17;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt1.Location = new System.Drawing.Point(12, 23);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt1.MaxLength = 1;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(37, 26);
            this.txt1.TabIndex = 16;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // grpKontrol
            // 
            this.grpKontrol.Controls.Add(this.btnOtoBul);
            this.grpKontrol.Controls.Add(this.lblToplamPuan);
            this.grpKontrol.Controls.Add(this.label4);
            this.grpKontrol.Controls.Add(this.label1);
            this.grpKontrol.Controls.Add(this.cmbJoker);
            this.grpKontrol.Controls.Add(this.btnHarfSec);
            this.grpKontrol.Controls.Add(this.lblHarfler);
            this.grpKontrol.Controls.Add(this.label3);
            this.grpKontrol.Controls.Add(this.btnKelimeYenioyun);
            this.grpKontrol.Controls.Add(this.btnReset);
            this.grpKontrol.Location = new System.Drawing.Point(20, 5);
            this.grpKontrol.Name = "grpKontrol";
            this.grpKontrol.Size = new System.Drawing.Size(504, 158);
            this.grpKontrol.TabIndex = 16;
            this.grpKontrol.TabStop = false;
            // 
            // btnOtoBul
            // 
            this.btnOtoBul.Location = new System.Drawing.Point(134, 111);
            this.btnOtoBul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOtoBul.Name = "btnOtoBul";
            this.btnOtoBul.Size = new System.Drawing.Size(110, 35);
            this.btnOtoBul.TabIndex = 20;
            this.btnOtoBul.Text = "Otomatik Bul";
            this.btnOtoBul.UseVisualStyleBackColor = true;
            this.btnOtoBul.Click += new System.EventHandler(this.btnOtoBul_Click);
            // 
            // lblToplamPuan
            // 
            this.lblToplamPuan.AutoSize = true;
            this.lblToplamPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamPuan.ForeColor = System.Drawing.Color.Red;
            this.lblToplamPuan.Location = new System.Drawing.Point(282, 30);
            this.lblToplamPuan.Name = "lblToplamPuan";
            this.lblToplamPuan.Size = new System.Drawing.Size(24, 20);
            this.lblToplamPuan.TabIndex = 16;
            this.lblToplamPuan.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Toplam Puan:";
            // 
            // grpKelime
            // 
            this.grpKelime.Controls.Add(this.label2);
            this.grpKelime.Controls.Add(this.txtKelime);
            this.grpKelime.Controls.Add(this.btnOnayla);
            this.grpKelime.Location = new System.Drawing.Point(20, 234);
            this.grpKelime.Name = "grpKelime";
            this.grpKelime.Size = new System.Drawing.Size(504, 63);
            this.grpKelime.TabIndex = 17;
            this.grpKelime.TabStop = false;
            // 
            // Form_kelime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 313);
            this.Controls.Add(this.grpKelime);
            this.Controls.Add(this.grpKontrol);
            this.Controls.Add(this.grpHarfSecimi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_kelime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1 KELİME";
            this.grpHarfSecimi.ResumeLayout(false);
            this.grpHarfSecimi.PerformLayout();
            this.grpKontrol.ResumeLayout(false);
            this.grpKontrol.PerformLayout();
            this.grpKelime.ResumeLayout(false);
            this.grpKelime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHarfler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKelimeYenioyun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbJoker;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnHarfSec;
        private System.Windows.Forms.GroupBox grpHarfSecimi;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.GroupBox grpKontrol;
        private System.Windows.Forms.Label lblToplamPuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpKelime;
        private System.Windows.Forms.Button btnOtoBul;
    }
}