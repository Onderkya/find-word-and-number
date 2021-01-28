using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _1_kelime_1_islem
{
    class Kelime_kontrol
    {
        OleDbConnection bag = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\sozluk.mdb");  // VT bağlantı cümlesi
        public char Joker { get; set; }

        /// PARAMETRE OLARAK GELEN KELİMENİN VERİTABANAINDA OLUP OLMADIĞINI SORAN METOT
        public bool veritabani_kelimekontrolu(string kelime)
        {
            bool onay;                                                  // Kontrol sonrası True/False yanıt gönderecek olan değişken                                        
            kelime = kelime.Trim();                                     // kelime sonunda boşluk varsa o kısımları kes
            bag.Open();                                                 // VT bağlantıyı aç
            string sorgu = "select * from turkce where SozcukAdi=@p1";  // VT sorgu cümlesi
            OleDbCommand c = new OleDbCommand(sorgu, bag);              // sorgu cümlesini nesneye al
            c.Parameters.AddWithValue("@p1", kelime);                   // gelen gelimeyi parametre olarak belirt
            OleDbDataReader dr = c.ExecuteReader();                     // sorguyu çalıştır
            if (dr.Read())                                              // eğer sorgu sonuç döndürürse;
                onay = true;                                            // onay TRUE yaz
            else                                                        // 
                onay = false;                                           // eğer sorgu sonuç döndürmezse; onay FALSE yaz
            bag.Close();                                                // VT bağlantıyı kapat
            
            return onay;
        }

        /// ELİMİZDEKİ HARFLERE GÖRE VERİTABANINDA UYGUN KELİMEYİ ARAYAN ALGORİTMA 
        public string otomatikBul(Harf _harfler)
        {
            string kelimeGonder = "BAŞARISIZ SORGU!";           
            
            bool kelimeonay = false;
            
            for (int i = 9; i >= 3; i--)                                // Veritabanında 9 harfli kelimelerden aramaya başlayarak geriye doğru gitmesi için gereken döngü
            {
                List<string> kelimeler = new List<string>();            //VT de bulduğu kelimeleri aktaracağı liste
                bag.Open();
                OleDbCommand c2 = new OleDbCommand("select * from turkce where LEN(SozcukAdi)=@p1", bag);   //döngü sayacına göre .... uzunluğundaki kelimeleri aratacak sorgu
                c2.Parameters.AddWithValue("@p1", i);
                OleDbDataReader dr = c2.ExecuteReader();                
                while (dr.Read())
                {
                    kelimeler.Add(dr[1].ToString());                    //sorguya karşılık gelen kelimeleri listeye aktar
                }
                bag.Close();

                foreach (string k_list in kelimeler)                    //listede bulunan her bir kelime için çalışan döngü
                {
                    List<char> harfler = new List<char>();              //clienttan gelen harflerin tutulacağı geçici liste
                    Joker = '!';                                        //joker kullanılmayacağı durumda gerçekleşen atama
                    foreach (char harfs in _harfler.Harfler)            //clinttaki harfleri geçici listeye aktaran döngü
	                {
		                harfler.Add(harfs);                             //aktarma işlemi
	                }

                    char tekharf;                                       //kelimeyi harfharf böleceğinden harfin tututlacağı değişken
                    for (int j = 0; j < k_list.Length; j++)             //listedeki kelimeyi harfharf bölen döngü
                    {
                        tekharf = Convert.ToChar(k_list.Substring(j, 1).ToUpper()); //her harfi sırası karşılığında değişkene atar
                        if(harfler.Contains(tekharf))                   //kelimedeki harfleri clienttan gelen liste ile uyuşmazlığını kontrol eden döngü
                        {
                            harfler.Remove(tekharf);                    //uyum varsa çakışmayı(mükerrer durumu) önlemesi için listeden bulunan harfi çıkartır
                            kelimeonay = true;                          //uyum varsa onay vardır
                        }
                        else if(Joker=='!')                             //tek harfin uymaması durumunda JOKER olarak kullanılabilmesi için atama yapar
                        {
                            Joker = tekharf;
                            kelimeonay = true;
                        }
                        else                                            //Joker hakkı kullanılmış ve uyumsuzluk devam ederse;
                        {
                            kelimeonay = false;                         //onay vermez
                            break;                                      //yeni kelimeyi taraması için döngüden çıkılır
                        }
                    }
                    if(kelimeonay)                                      //döngüden çıkılmış ve kelimeye onay verilmişse;
                    {
                        kelimeGonder = k_list;                          //uyum sağlayan kelime geri değer gönderilmesi için değişkene atanır
                        break;                                          //uyum sağlandığı için yeni kelime taranmaması adına döngüden çıkılır
                    }
                }
                if (kelimeonay)                                         //uyum sağlayan kelime bulunmuş ise;
                    break;                                              //veritabanından yeni kelimeler aranmaması için döngüden çıkılır
            }

            return kelimeGonder;                                        //uyum sağlayan kelime clienta gönderilir.
            
        }
    }
}
