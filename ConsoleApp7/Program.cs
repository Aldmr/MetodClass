using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
           
            musteri1.musteriAdi = "Onur";
            musteri1.musteriSoyadi = "Aldemir";
            musteri1.musteriYasi = 26;
            musteri1.musteriNotu = 93;

            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Sanem Ezgi";
            musteri2.musteriSoyadi = "Şahin";
            musteri2.musteriYasi = 26;
            musteri2.musteriNotu = 97;

            MusteriManager Ekle1 = new MusteriManager();

            Ekle1.musteriEkle(musteri1);
            Ekle1.musteriEkle(musteri2);
            Console.ReadLine();

        }

        
    }
}
