using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_kelime_1_islem
{
    class Sayi
    {
        public int[] Sayilar { get; set; }
        public int HedefSayi { get; set; }

        /// SAYILARIN ÜRETİLDİĞİ METOT
        public void uret()
        {
            Sayilar = new int[6];                               // Sayıların saklanacağı dizi
            Random r = new Random();                            // Rastgele sayı üretecek olan nesne

            for (int i = 0; i < Sayilar.Length; i++)            // Her bir dizi elemanı için döngü çalıştır
            {
                Sayilar[i] = r.Next(1, 10);                     // Her bir dizi elemanına 1-10 arasında değer ataması yap
            }

            Sayilar[5] *= 10;                                   // Kullanılacak son eleman 10un katlarından oluştur
            HedefSayi = r.Next(100, 1000);                      // Hedef sayı 3 basamaklı bir sayı olarak oluştur
            sirala(Sayilar);                                    // Sayıları sıralamak için fonksiyon çağır                     
        }
        
        /// SAYILARIN SEÇİLDİĞİ METOT
        public void sayiSec(Sayi sayisec)
        {
            Sayilar = new int[6];                               // Sayıların saklanacağı dizi

            for (int i = 0; i < Sayilar.Length; i++)            // Seçilen sayıları kullanılacak sayılar dizinine yazan döngü
            {
                Sayilar[i] = sayisec.Sayilar[i];                // parametre gelen her sayıyı Sayılar kümesine yaz
            }
            Sayilar[5] *= 10;                                   // son elemanı 10 ile çarparak yaz

            Random r = new Random(); 
            sirala(Sayilar);                                    // Sayıları sıralamak için fonksiyon çağır                     
        }
        
        /// SAYILARIN SIRALANDIĞI METOT
        private void sirala(int[] dizi)
        {
            int tmp;                                            // Yer değiştirmeyi geçici tutan değişken

            for (int i = 0; i < dizi.Length; i++)
            {
                bool sirali = true;
                for (int j = dizi.Length - 1; j > i; j--)       //i. geçiş için i eksik dönüş
                {
                    if (dizi[j - 1] > dizi[j] && dizi[j] != 0)  //şayet buraya girmiyorsak dizi sıralıdır
                    {
                        sirali = false;                         //şayet giriyorsak sıralı değildir
                        tmp = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = tmp;
                    }
                }

                if (sirali)                                     // hiç bir değer yer değiştirmiyorsa dizi sıralıdır döngüden çık
                    break;
            }
        }
        
        /// SAYILARIN YAZDIRILDIĞI DEĞER DÖDÜREN FONKSİYON
        public string labelyazdir()
        {
            string mesaj = null;
            for (int i = 0; i < Sayilar.Length-1; i++)          // sonn sayı hariç diğer elemanlar için döngü çalıştır
            {
                if (Sayilar[i] != 0)
                    mesaj += Sayilar[i].ToString() + " - ";     // Sayılar arası ( - ) işareti koyarak mesajı oluşturur
            }
            mesaj += Sayilar[5].ToString();                     // son elemanı metne ekle
            return mesaj;
        }
        
        /// HEDEF SAYIYI YAZDIRAN METOT
        public string hedefSayiYazdir()
        {
            return HedefSayi.ToString();
        }
    }
}
