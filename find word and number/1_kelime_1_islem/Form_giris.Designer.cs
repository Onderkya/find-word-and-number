namespace _1_kelime_1_islem
{
    partial class Form_giris
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
            this.btnKelime = new System.Windows.Forms.Button();
            this.btnislem = new System.Windows.Forms.Button();
            this.btnTopPuan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKelime
            // 
            this.btnKelime.Location = new System.Drawing.Point(32, 35);
            this.btnKelime.Margin = new System.Windows.Forms.Padding(8);
            this.btnKelime.Name = "btnKelime";
            this.btnKelime.Size = new System.Drawing.Size(212, 58);
            this.btnKelime.TabIndex = 0;
            this.btnKelime.Text = "1 Kelime";
            this.btnKelime.UseVisualStyleBackColor = true;
            this.btnKelime.Click += new System.EventHandler(this.btnKelime_Click);
            // 
            // btnislem
            // 
            this.btnislem.Location = new System.Drawing.Point(297, 35);
            this.btnislem.Margin = new System.Windows.Forms.Padding(8);
            this.btnislem.Name = "btnislem";
            this.btnislem.Size = new System.Drawing.Size(212, 58);
            this.btnislem.TabIndex = 1;
            this.btnislem.Text = "1 İşlem";
            this.btnislem.UseVisualStyleBackColor = true;
            this.btnislem.Click += new System.EventHandler(this.btnislem_Click);
            // 
            // btnTopPuan
            // 
            this.btnTopPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopPuan.Location = new System.Drawing.Point(32, 116);
            this.btnTopPuan.Name = "btnTopPuan";
            this.btnTopPuan.Size = new System.Drawing.Size(477, 38);
            this.btnTopPuan.TabIndex = 2;
            this.btnTopPuan.Text = "Toplam Puan";
            this.btnTopPuan.UseVisualStyleBackColor = true;
            this.btnTopPuan.Click += new System.EventHandler(this.btnTopPuan_Click);
            // 
            // Form_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 176);
            this.Controls.Add(this.btnTopPuan);
            this.Controls.Add(this.btnislem);
            this.Controls.Add(this.btnKelime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "Form_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1 KELİME / 1 İŞLEM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKelime;
        private System.Windows.Forms.Button btnislem;
        private System.Windows.Forms.Button btnTopPuan;

    }
}

