using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_kelime_1_islem
{
    public partial class Form_giris : Form
    {
        public Form_giris()
        {            
            InitializeComponent();
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            Form_islem formislem = new Form_islem();                // formislem örneğini yarat
            formislem.ShowDialog();                                 // 1 İŞLEM formunu aç
        }

        private void btnKelime_Click(object sender, EventArgs e)
        {
            Form_kelime formkelime = new Form_kelime();             // formkelime örneğini yarat
            formkelime.ShowDialog();                                // 1 KELİME formunu aç
        }

        private void btnTopPuan_Click(object sender, EventArgs e)
        {
            Puan_hesapla ph = new Puan_hesapla();                   // puanhesapla sınıfının örneğini yarat
            MessageBox.Show(ph.puansor().ToString());               // puansor metodunu çağır gelen yanıt toplampuan(static) yazdır
        }
    }
}
