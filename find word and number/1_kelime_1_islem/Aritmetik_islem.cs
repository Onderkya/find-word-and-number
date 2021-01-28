using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_kelime_1_islem
{
    class Aritmetik_islem
    {
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }
        public string Operator { get; set; }
        public int Sonuc { get; set; }

        /// SEÇİMİ YAPILAN SAYILAR ARASINDAKİ ARİTMETİK İŞLEMİ YAPAN METOT
        public void Hesapla()
        {
            if (Sayi1 != 0 && Operator != null && Sayi2 != 0)
            {
                switch (Operator)
                {
                    case "+":
                        Sonuc = Sayi1 + Sayi2;
                        break;

                    case "-":
                        Sonuc = Sayi1 - Sayi2;
                        break;

                    case "x":
                        Sonuc = Sayi1 * Sayi2;
                        break;

                    case "/":
                        Sonuc = Sayi1 / Sayi2;
                        break;
                }                
            }
        }
    }
}
