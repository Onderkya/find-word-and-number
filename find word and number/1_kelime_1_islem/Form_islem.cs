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
    public partial class Form_islem : Form
    {
        public Form_islem()
        {
            InitializeComponent();
            kullanilacakSayilarButonuOlustur();                             // Buton oluştur metodunu çağır
            yeniOyun();                                                     // YENİ OYUN metodunu çağır
        }

        Button[,] but = new Button[2,6];                                    // Kullanılacak sayıların buton dizisi
        List<Button> clrBut = new List<Button>();                           // Geçici kilitlenecek butonların tekrar açılması için buton listesi
        Sayi say = new Sayi();                                              // Sayı değerlerini tutucak nesne
        Aritmetik_islem aritmetikislem = new Aritmetik_islem();             // aritmetik işlemlerin yapılacağı nesne
        bool islemOperator = false;                                         // işlem sırası SAYI da ise FALSE değerini, sıra İŞLEM OPERATÖRÜNDE ise TRUE değerini tutacak olan boolean
        bool esittir = false;                                               // üst üste eşittir butonuna basılmamasını kontrol eden değişken
        Puan_hesapla ph = new Puan_hesapla();                               // puan hesaplamada kullanılacak olan nesne
        List<int> liste2 = new List<int>();
                        
        /// KULLANILACAK SAYILAR İÇİN DİNAMİK BUTON OLUŞTURAN METOT        
        private void kullanilacakSayilarButonuOlustur()
        {
            int top = 20;                                                   // yukarıdan hiza ilk değer
            int left = 5;                                                   // soldan hiza ilk değer
            for (int i = 0; i <= but.GetUpperBound(0); i++)                 // alt satıra geçmek için çalışacak döngü
            {
                for (int j = 0; j <= but.GetUpperBound(1); j++)             // tek satırda eklenecek butonlar için çalışacak döngü
                {
                    but[i,j] = new Button();
                    but[i,j].Width = 60;                                    // En
                    but[i,j].Height = 30;                                   // Boy
                    but[i,j].Left = left;                                   // Soldan hiza
                    but[i,j].Top = top;                                     // Yukarıdan hiza
                    left += 65;                                             // Soldan hizayı artır
                    grpSayiButonlari.Controls.Add(but[i,j]);                // Grupbox içinde butonu oluştur
                    but[i,j].Click += new EventHandler(Sayibut_click);      // Butonların tıklandığında olayını belirle
                    if(i==1)                                                // Eğer alt satıra geçildiyse
                        but[i, j].Visible = false;                          // alt satırdaki butonların visible=false yap
                }
                top+= 35;                                                   // alt satır butonları için yukarıdan hizayı 30 artır
                left = 5;                                                  // alt satır butonlar için soldan hizayı ilk değer yap
            }
        }
        
        /// YENİ OYUN İŞLEVLERİNİ OLUŞTURAN METOT        
        private void yeniOyun()
        {
            say.uret();                                                     // yeni kullanılacak sayıların ve yeni hedef sayının üretilmesi metodunu çağır
            lblSayilar.Text = say.labelyazdir();                            // sayıları LABEL yazdır
            lblHedefSayi.Text = say.hedefSayiYazdir();                      // hedef sayıyı LABEL yazdır
            reset();                                                        // RESET metodunu çağır
            int ToplamPuan = ph.puansor();                                  // Toplam puan için değişken oluştur ve Toplam Puanı soran metodu çağır
            lblToplamPuan.Text = ToplamPuan.ToString();                     // toplam puanı label a yazdır
        }
        
        /// PASİF SAYI BUTONLARIN TEKRAR KULLANIMI İÇİN RESET METOT        
        private void reset()
        {
            for (int i = 0; i <= but.GetUpperBound(0); i++)                 // alt satıra geçmek için çalışacak döngü
            {
                for (int j = 0; j <= but.GetUpperBound(1); j++)             // tek satırda eklenecek butonlar için çalışacak döngü
                {
                    but[i,j].Enabled = true;                                // Sayılar butonlarını enable=true yap
                    but[i,j].Text = say.Sayilar[j].ToString();              // Sayilar butonlarının text=sayılar listesindekini yazdır

                    but[1,j].Visible = false;                               // alt satır butonlarını visible=false yap
                    but[1, j].Text = null;                                  // alt satır butonların text=null yap
                }
            }
            clr();                                                          // CLEAR metodunu çağır
            btnOnayla.Enabled = false;                                      // onayla butonunu kapat
            listislemGecmisi.Items.Clear();                                 // işlem geçmişini temizle
            grpSayiSec.Visible = false;
        }
        
        /// YENİ OYUN BUTONUNA BASILDIĞINDA / EVENT        
        private void btn_islem_yenioyun_Click(object sender, EventArgs e)
        {
            yeniOyun();                                                     // YENİ OYUN metodunu çağır
        }

        /// RESET BUTONUNA BASILDIĞINDA / EVENT        
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();                                                        // RESET metodunu çağır
        }

        /// TAMAMLANMAMIŞ İŞLEMİ TEMİZLEYEN METOT       
        private void clr()
        {
            txtDisplay.Text = null;                                         // Display ekranı temizle
            islemOperator = false;                                          // İşlem sırasını SAYI de
            aritmetikislem.Operator = null;                                 // İşlem operatörünü temizle
            aritmetikislem.Sayi1 = 0;                                       // SAYI1 sıfır yap
            aritmetikislem.Sayi2 = 0;                                       // SAYI2 sıfır yap           
            esittir = false;                                                // Üstüste EŞİTTİR butonuna basılmaması için FALSE yap
        }
                
        ///  PUAN SORGULAYAN METOT
        private void sonucal()
        {
            string mesaj = null;
            if (say.HedefSayi != 0)                                         // Hedef sayı sıfırdan farklı ise
            {
                int puan = ph.islempuanlama(say.HedefSayi, aritmetikislem.Sonuc);// puan değişkenine puan hesapla metodundan gelen yanıtı ata
                if (puan == 10)
                    mesaj = "TEBRİKLER, tam sayıya ulaştınız " + puan + " puan kazandınız";
                else if (puan <= 0)
                    mesaj = "Üzgünüm, hedef sayıya yeteri kadar yaklaşamadınız.";
                else
                    mesaj = "TEBRİKLER, " + (10 - puan) + " yaklaşık bildiniz " + puan + " puan kazandınız";
                MessageBox.Show(mesaj);
                yeniOyun();                                                 // Puan hesaplandıktan sonra yeni oyun için YENİ OYUN metodunu çağır
            }
        }
                
        /// SAYI SEÇ BUTONUNA BASILDIĞINDA / EVENT        
        private void btnSayiSec_Click(object sender, EventArgs e)
        {
            grpSayiSec.Visible = true;                                      //Sayıların seçileceği grpupbox ı görünür yap
            foreach (Control item in grpSayiSec.Controls)
            {
                if (item is TextBox)
                    item.Text = null;                                       // textboxların değerlerini boşalt
            }
            txt1.Focus();
        }
        
        /// SAYI SEÇİMİ KUTULARINA GİRİŞLERİN KONTROLÜ        
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // textbox a sadece sayı girilmesini sağla
        }
        
        /// SAYI SEÇİMİ TAMAMLANDIĞINDAKİ BUTONUNA BASILDIĞINDA / EVENT        
        private void btnSec_Click(object sender, EventArgs e)
        {
            Sayi sayigonder = new Sayi();                                   // Sayı clasından örnek yarat
            sayigonder.Sayilar = new int[6];                                // Sayılar kümesinden örnek yarat
            int i = 0;                                                      // sayaç kontrolü
            foreach (Control item in grpSayiSec.Controls)                   // groupbox içindeki herbir textbox nesnesi için
            {
                if (item is TextBox)
                {
                    if (!string.IsNullOrEmpty(item.Text))                    // texxtbox daki değer boş değilse;
                    {
                        sayigonder.Sayilar[i] = Convert.ToInt16(item.Text); // textbox daki değeri sayılar kümesine yaz
                        i++;                                                // sayacı artır
                    }
                    else
                    {
                        Array.Clear(sayigonder.Sayilar, 0, 6);               // textboxdaki değer boş ise kümeyi temizle
                        MessageBox.Show("Kutucuklar boş bırakılamaz!");
                        item.Focus();
                        break;                                               // döngüden çık
                    }
                }
            }
            if (i == 6)                                                      // foreach döngüsü tam eleman sayısı kadar çalışmışsa eğer;
            {
                say.sayiSec(sayigonder);                                     // sayı seç metodunu çağır /  textbox a girilen değerleri parametre olarak gönder
                lblSayilar.Text = say.labelyazdir();                         // seçilen sayıları label e yazdıran metodu çağır                  
                reset();                                                     // reset metodunu çağır
                grpSayiSec.Visible = false;                                  // sayıların seçildiği groupbox ı görünmez yap
            }
        }
        
        /// SAYILAR BUTON GRUBUNA BASILDIĞINDA / EVENT        
        private void Sayibut_click(object sender, EventArgs e)
        {
            if (islemOperator == false && aritmetikislem.Sayi2 == 0)        // Sıra SAYI' larda ise;
            {
                Button btnSecim = (sender as Button);                       // Seçilen butonun nesnesini oluşturur
                txtDisplay.Text += btnSecim.Text;                             // Seçilen sayıyı TEXTBOX yazar 
                btnSecim.Enabled = false;                                   // Seçilen butonu kilitler
                islemOperator = true;                                       // Sıranın İŞLEM OPERATÖR ünde olduğunu işaretler

                if (aritmetikislem.Sayi1 == 0)                              // eğer SAYI1 yoksa;
                    aritmetikislem.Sayi1 = Convert.ToInt16(btnSecim.Text);  // basılan buton kaçıncı indexte ise sayılar dizindeki o sayıyı SAYI1 e atar
                else                                                        // SAYI1 varsa;
                {
                    aritmetikislem.Sayi2 = Convert.ToInt16(btnSecim.Text);  // basılan buton kaçıncı indexte ise sayılar dizindeki o sayıyı SAYI2 ye atar
                    esittir = true;                                         // Eşittir butonuna basılabilmesi için TRUE yap
                }
                    
                clrBut.Add(btnSecim);                                       // son yapılan işlemin geri alınması ihtimaline karşın son tıklanan butonu liste al
            }
        }
        
        /// ARİTMETİK İŞLEMELER BUTON GRUBUNA BASILDIĞINDA / EVENT        
        private void islemBut_click(object sender, EventArgs e)
        {
            if (islemOperator && aritmetikislem.Operator == null)           // Sıra OPERATÖR' de ise;  
            {
                Button btnOpr = (sender as Button);                         // Seçilen butonun nesnesini oluşturur
                aritmetikislem.Operator = btnOpr.Text;                      // Operatör nesnesine seçilen işlemi atar
                txtDisplay.Text += btnOpr.Text;                               // Seçilen aritmetik işlemi TEXTBOX a yazar
                islemOperator = false;                                      // Operatör sırasını SAYI ya salar
            }
        }
        
        /// EŞİTTİR BUTONUNA BASILDIĞINDA / EVENT        
        private void btnEsit_Click(object sender, EventArgs e)
        {
            aritmetikislem.Hesapla();                                       // SAYI1 ve SAYI2 için hesaplama yapan metodu çağır
            if (aritmetikislem.Sonuc != 0 && esittir)                       // eğer SONUÇ sıfırdan farklı ise;
            {
                btnOnayla.Enabled = true;                                   // onayla butonunu aç
                txtDisplay.Text += "=" + aritmetikislem.Sonuc;                // Display e SONUÇ' u yazdır
                listislemGecmisi.Items.Add(txtDisplay.Text);
                foreach (Button item in but)                                // bulunan SONUCU kullanılabilir İLK butona yazdırmak için çalışan döngü
                {
                    if (item.Text == null || item.Text == "")               // buton kullanılabilir mi?
                    {
                        item.Text = aritmetikislem.Sonuc.ToString();        // buton text özelliğine SONUC değerini yaz
                        item.Visible = true;                                // butonu görünür yap
                        clrBut.Clear();                                     // İşlem onaylandığı için geçici kilitlenen butonlar listesini temizle
                        clr();                                              // CLEAR metodunu çağır
                        break;                                              // döngüden çık
                    }
                }               
            }
        }
        
        /// CLR BUTONUNA BASILDIĞINDA / EVENT        
        private void btnClr_Click(object sender, EventArgs e)
        {
            foreach (Button item in clrBut)                                 // geçici kilitlenen butonlar listesinde tüm elemanlar için uygulanacak döngü            
                item.Enabled = true;                                        // geçici kilitlenen butonlar listesindeki butonların kilidini aç
            clr();                                                          // CLEAR metodunu çağır
        }
       
        /// ONAYLA BUTONUNA BASILDIĞINDA / EVENT        
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            sonucal();
        }

        /// SAYILARA GÖRE OTOMATİK SONUCU KENDİSİ BULAN ALGIRİTMA 
        private void btnOtoHesapla_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            uint sayac = 0;                                                 //algoritmanın türettiği işlem sayısının sayacı
            uint yaklasik = 0;                                              //kaç yaklaşıkta arama yapacağını işaret eden değişken
            int sonuc = 0;                                                  //algoritmanın işlem sonrası buludğu sonucu tutan değişken
            foreach (int item in say.Sayilar)                               //clienttan gelen sayıların geçici listeye aktarıldığı döngü
            {
                liste2.Add(item);                                           //aktarma işlemi
            }
            listislemGecmisi.Items.Clear(); 
            while (true)                                                    //sonuç bulunanan kadar çalışacak olan döngü
            {
                sayac++;                                                    //her işlem için(döngü başına) sayacı 1 artır
                yaklasik = sayac / 50000;                                   //her 50.000 deneme sonrasında yaklaşık bandını 1 genişletecek işlem
                if (yaklasik > 9)     //9 yaklaşığa kadar puanlama yapıldığından daha fazla sonuç için döngünün çalışıp çalışmayacağını kontrol eden mantıksal sınama
                {
                    listislemGecmisi.Items.Clear();
                    MessageBox.Show("Sonuç hesaplanamadı");
                    break;
                }                    
                if (liste2.Count > 1)                                       //eğer sayılar listesinde 1den fazla eleman varsa
                {
                    int x = liste2[r.Next(0, liste2.Count)];                //listeden bir elemanı al X değişkenine aktar
                    liste2.Remove(x);                                       //aldığın elemanı tekrar kullanımını önlemek için listeden çıkart
                    int y = liste2[r.Next(0, liste2.Count)];                //listenin kalanından bir başka eleman al Y değişkenine aktar
                    liste2.Remove(y);                                       //aldığın elemanı tekrar kullanımını önlemek için listeden çıkart
                    int i = r.Next(0, 3);                                   //matematiksel dört işlem için değer seç;
                    if (i == 0)                                             //seçilen değer 0 ise
                    {
                        liste2.Add(x + y);                                  // X + Y işlemini gerçekleştir ve listeye aktar
                        listislemGecmisi.Items.Add(x + "+" + y + "=" + (x + y));
                    }

                    else if (i == 1)                                        //seçilen değer 1 ise
                    {
                        liste2.Add(x - y);                                  // X - Y işlemini gerçekleştir ve listeye aktar
                        listislemGecmisi.Items.Add(x + "-" + y + "=" + (x - y));
                    }

                    else if (i == 2)                                        //seçilen değer 2 ise
                    {
                        liste2.Add(x * y);                                  // X * Y işlemini gerçekleştir ve listeye aaktar
                        listislemGecmisi.Items.Add(x + "*" + y + "=" + (x * y));
                    }

                    else                                                    //seçilen işlem 3 ise
                    {
                        liste2.Add(x / y);                                  // X / Y işlemini gerçekleştir ve listeye aktar
                        listislemGecmisi.Items.Add(x + "/" + y + "=" + (x / y));
                    }

                }
                else                                                        // eğer sayılar listesinde bir adet eleman kalmış ise;
                {
                    foreach (int item in liste2)
                    {
                        sonuc = item;                                       //kalan tek elemanı sonuc değişkenine aktar
                    }
                    int puan = say.HedefSayi - sonuc;                       //sonucun hedef sayıdan ne kadar yaklaşık olduğunu hesapla
                    if (puan < 0)                                           // eğer yaklaşık negatif çıkar ise;
                        puan *= -1;                                         // mutlak değeri almak için -1 ile çarp
                    if (puan == yaklasik)                                   //bulunan puan aranan yaklaşığa eşit ise tekrar işlem yapmamak için döngüden çık;
                        break;                                          
                    else                                                    //eğer bulunan sonuç aranan yaklaşık değer eşiğinde değil ise yeni işlemler için sayılar listesini temizle ve yenile
                    {
                        liste2.Clear();
                        foreach (int item in say.Sayilar)
                        {
                            liste2.Add(item);
                        }
                        listislemGecmisi.Items.Clear();
                    }

                }

            }
            if (yaklasik < 10)                                              //aranan yaklaşık değer eşiği 9u aşılmamaış ise bulunan sonucu clienta gönder
            {
                aritmetikislem.Sonuc = sonuc;
                sonucal();
            }
        }
    }
}
