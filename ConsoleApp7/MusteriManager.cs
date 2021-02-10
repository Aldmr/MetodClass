using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class MusteriManager
    {
        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAdi + " "+ musteri.musteriSoyadi+ " Musterisi Eklenmiştir.");
            
        }
        public void musteriListele()
        {
            Console.WriteLine("Müşteri Listelendi");
        }
        public void musteriSilme()
        {
            Console.WriteLine("Müşteri Silindi");
        }
    }
}
