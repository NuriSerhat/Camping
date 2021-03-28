using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention = isimlendirme

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebirkler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebirkler. Sepete eklendi : " + urunAdi + " " + aciklama + "  " + fiyat);
        }

    }
}
