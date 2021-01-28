using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_kelime_1_islem
{
    class Puan_hesapla
    {
        public static int ToplamPuan = 0;

        /// 1 KELİME DEN GELEN PARAMETRELERE GÖRE PUAN HESAPLAYAN METOT
        public int kelimepuanlama(string kelime)
        {
            int harfsayisi = kelime.Length;                             // gelen kelimenin harf  saysını öğren
            int bolum = harfsayisi / 5;                                 // harf sayısını 5' e bölümü
            int kalan = harfsayisi % 5;                                 // harf sayısının mod 5' i
            int hesaplananpuan = (harfsayisi * bolum) + kalan;          // harf sayısını bölüm ile çarp kalanı ekle
            if (harfsayisi == 9)                                        // harf sayısı 9 ise
                hesaplananpuan += 2;                                    // ekstra +2 puan daha ekle
            ToplamPuan += hesaplananpuan;                               // hesaplanan puanı TOPLAMPUAN a ekle
            return hesaplananpuan;
        }

        /// 1 İŞLEM DEN GELEN PARAMETRELERE GÖRE PUAN HESAPLAYAN METOT
        public int islempuanlama(int hedefsayi, int bulunansayi)
        {
            int fark = hedefsayi - bulunansayi;                         // Hedef sayıdan çıkan sonucu çıkar ve FARK a yazdır
            if (bulunansayi > hedefsayi)                                // Eğer hesaplanan sonuç hedef sayıdan büyükse -1 ile çarp
                fark *= -1;                                             // -1 ile çarp
            int hesaplananpuan = 10 - fark;                             // 10 tam puandan aradaki farkı çıkar ve puan olarak ata
            if(hesaplananpuan>0)                                        // Eğer hesaplanan puan 0 dan büyükse sonucu Toplam puana ekle
                ToplamPuan += hesaplananpuan;                           // hesaplanan puanı TOPLAMPUAN a ekle
            return hesaplananpuan;
        }
        
        /// TOPLAM PUANI YANIT OLARAK GÖNDEREN METOT
        public int puansor()
        {
            return ToplamPuan;
        }
    }
}
