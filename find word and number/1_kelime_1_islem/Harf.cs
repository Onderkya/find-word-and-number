using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_kelime_1_islem
{
    class Harf
    {
        public char[] Harfler = new char[9];
        public char[] Alfabe = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };

        /// ALFABE DİZİSİNDEN 8 TANE RASTGELE HARF SEÇİMİ YAPAN METOT
        public void harfuret()
        {
            Random r = new Random();
            for (int i = 0; i < 8; i++)                                 // 8 defa çalış
            {
                Harfler[i] = Alfabe[r.Next(0,28)];                      // HARF diisine sırasıyla atama yap
            }
        }
        
        /// SEÇİMİ YAPILAN HARFLERİ METİN İFADESİ OLARAK GÖNDEREN METOT
        public string harfYazdir()
        {
            string hrf = "";
            foreach (char item in Harfler)                              // rastgele seçilen harfler dizisindeki her bir eleman kere çalış
            {
                hrf += item + " - ";                                    // harflerin arasında ( - ) olacak şekilde birleştir
            }
            return hrf.Substring(0, 29);                                // döngü sonunda ( - ) eklenen karakteri almayacak şekilde metin ifadesi geri gönder
        }
        
        /// OLUŞTURULAN KELİMENİN İÇİNDE DOĞRU HARFLERİ KONTROL EDEN METOT
        public bool harflistekontrol(string kelime, char joker)
        {            
            List<char> geciciHarfListe = new List<char>();              // kontrol için geçici bir harf listesi oluştur
            geciciHarfListe.Add(joker);                                 // joker olarak seçilen harfi geçici listeye ekle
            foreach (char item in Harfler)                              // rastgele seçilen her harfi geçici listeye ekle
            {
                geciciHarfListe.Add(item);
            }

            bool onay = false;                                          // Kontrol sonrası True/False yanıt gönderecek olan değişken
            kelime = kelime.Trim().ToUpper();                           // parametre gelen kelimeyi BÜYÜK HARF olarak dönüştür
            for (int i = 0; i < kelime.Length; i++)                     // kelimenin uzunluğu kadar çalış
            {
                char tekharf = Convert.ToChar(kelime.Substring(i, 1));  // kelimeyi harf harf parçala
                if (geciciHarfListe.Contains(tekharf))                  // parçalanan harfler geçici listede varmı?
                {
                    geciciHarfListe.Remove(tekharf);                    // parçalanan harfler geçici listede varsa mükerrer sorgu olmaması için geçici listeden eşleşen elemanı çıkar
                    onay = true;                                        // onay TRUE yaz
                }
                else                                                    // geçici listede bulunmayan harf çıkmışsa
                {
                    onay = false;                                       // onay FALSE yaz
                    break;                                              // döngüden çık (en az 1 tane bile eşleşmeyen harf varsa kelime geçersizdir)!!!
                }
            }
            return onay;
        }        
    }
}
