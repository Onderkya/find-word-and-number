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
    public partial class Form_kelime : Form
    {
        public Form_kelime()
        {            
            InitializeComponent();
            yeniOyun();
        }
        
        Harf h = new Harf();                                                    // harf sınıfından örnek yarat
        Kelime_kontrol kk = new Kelime_kontrol();                               // girilen kelime kontrol sınıfınından örnek yarat
        Puan_hesapla ph = new Puan_hesapla();                                   // puan hesaplama nesnesi

        /// YENİ OYUN İŞLEVLERİNİ OLUŞTURAN METOT/
        private void yeniOyun()
        {
            h.harfuret();                                                       // Rastgele 8 harf üreten metodu çağır            
            lblHarfler.Text = h.harfYazdir();                                   // oluşturulan harfleri LABEL a yazdır            
            reset();                                                            // reset metodunu çağır
            int ToplamPuan = ph.puansor();                                      // Toplam puan için değişken oluştur ve Toplam Puanı soran metodu çağır
            lblToplamPuan.Text = ToplamPuan.ToString();                         // toplam puanı label a yazdır
        }
       
        /// JOKER ELEMANI YENİDEN SEÇİMİ İÇİN RESET METODU
        private void reset()
        {
            txtKelime.Text = null;                                              // textbox sıfırla
            cmbJoker.Items.Clear();                                             // Joker harf combosunu temizle
            foreach (char item in h.Alfabe)                                     // ALFABE listesinde her eleman için;
            {
                cmbJoker.Items.Add(item);                                       // Joker combosuna alfabedeki her elemanı ekle
            }
            grpHarfSecimi.Visible = false;                                      // harf seçimi groupbox ını görünmez yap
        }
        
        /// YENİ OYUN BUTONUNA BASILDIĞINDA / EVENT
        private void btn_kelime_yenioyun_Click(object sender, EventArgs e)
        {
            yeniOyun();                                                         // Yeni oyun metodunu çağır
        }
        
        /// RESET BUTONUNA BASILDIĞINDA / EVENT
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();                                                            // reset metodunu çağır
        }
        
        /// HARF SEÇ BUTONUNA TIKLANDIĞINDA / EVENT
        private void btnHarfSec_Click(object sender, EventArgs e)
        {
            grpHarfSecimi.Visible = true;                                        // harf seçimi öğelerinin olduğu groupbox ı görünür yap
            foreach (Control item in grpHarfSecimi.Controls)                     // her bir textbox öğesi için;
            {
                if (item is TextBox)
                    item.Text = null;                                            // textbox içeriğini boşalt
            }
        }
        
        /// HARF SEÇİMİ KUTULARINA GİRİŞLERİN KONTROLÜ
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar); // textbox a sadece harf girilmesini sağla
        }
        
        /// SEÇİLEN HARFLERİN ONAYLANMASI BUTONUNA TIKLANDIĞINDA / EVENT
        private void btnSec_Click(object sender, EventArgs e)
        {
            int i = 7;                                                           // harf kümesi kadar sayaç oluştur
            foreach (Control item in grpHarfSecimi.Controls)                     // her bir harf kutusu için;
            {
                if (item is TextBox)
                {

                    if (!string.IsNullOrEmpty(item.Text) && i >= 0)              // eğer harf kutusu boş değilse;
                    {
                        h.Harfler[i] = Convert.ToChar(item.Text.ToUpper());      // harfler kümesinin sayaç elemanına seçilen harfi yaz
                        i--;                                                     // sayacı azalt
                    }
                    else                                                         // eğer harf kutusu boş ise;
                    {
                        Array.Clear(h.Harfler, 0, h.Harfler.Length);             // harf kümesini temizle
                        MessageBox.Show("Boş kutu bırakmayınız");                // mesaj gönder
                        item.Focus();                                            // boş harf kutusuna odaklan
                        break;                                                   // döngüden çık
                    }
                }
                lblHarfler.Text = h.harfYazdir();                                // kullanılacak harfleri label e yazdıran metodu çağır
                if (i == 0)
                    grpHarfSecimi.Visible = false;
            }
        }
        
        /// TEXTBOX DEĞERİ HER DEĞİŞTİĞİNDE / EVENT
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtKelime.Text.Trim().Length >= 3)                               // girilen kelime 3 harften fazla ise;
                btnOnayla.Enabled = true;                                       // Onayla butonunu aktifleştir
            else                                                                // girilen kelime 3 harften az ise;
                btnOnayla.Enabled = false;                                      // Onayla butonunu pasifleştir
        }
        
        /// ONAYLA BUTONUNA BASILDIĞINDA / EVENT
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int puan = 0;                                                        // puan değişkeni oluştur
            char Joker = Convert.ToChar(cmbJoker.SelectedItem);                  // joker değişkenine combobox ta bulunan elemanı ata
            string Kelime = txtKelime.Text;                                       // girilen kelimeyi değişkene ata
            string mesaj;
            bool HarfListesiYanıt = h.harflistekontrol(Kelime, Joker);           // Girilen kelimenin HARF LİSTESİ nde olup olmadığı yanıtını döndüren metodu çağır

            if (HarfListesiYanıt)                                                // HARF LİSTESİ yanıtı TRUE ise;
            {
                bool KelimeKontrolYanıt = kk.veritabani_kelimekontrolu(Kelime);  // girilen kelimenin anlamlı/anlamsız kontrolünü yapıp yanıt döndüren metodu çağır;
                if (KelimeKontrolYanıt)                                          // Kelime kontrol yanıtı TRUE ise;
                {                    
                    puan = ph.kelimepuanlama(Kelime);                            // puan değişkenine puan hesaplama sınıfından gelen yanıtı yaz
                    mesaj = "TEBRİKLER, " + Kelime.Length + " harfli kelimeniz karşılığında " + puan + " puan kazandınız";
                    yeniOyun();                                                  // yeni oyun metodunu çağır
                }                    
                else                                                             // kelime kontrol yanıtı FALSE ise;
                {
                    mesaj = "Üzgünüm, geçersiz kelime, puan kazanamadınız";
                }                    
            }
            else                                                                 // HARF LİSTESİ yanıtı FALSE ise;
                mesaj = "Geçersiz harf kullanımı, lütfen girdiğiniz kelimeyi tekrar kontrol ediniz";           
                
            MessageBox.Show(mesaj);
        }

        private void btnOtoBul_Click(object sender, EventArgs e)
        {
            string turetilen = kk.otomatikBul(h).ToUpper();
            MessageBox.Show("Türetilen kelime: '"+turetilen+"'\n\nJoker harf: '"+kk.Joker+"'");
            txtKelime.Text = turetilen;
            cmbJoker.Text = kk.Joker.ToString();
        }
    }
}
