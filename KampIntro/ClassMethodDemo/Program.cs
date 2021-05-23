using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Fırat";
            musteri1.SoyAdi = "Alçın";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Fırat";
            musteri2.SoyAdi = "Alabuga";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Enes";
            musteri3.SoyAdi = "Çiçek";


            Musteri[] musteriler = new Musteri[]
            {
                musteri1,
                musteri2,
                musteri3
            };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteriler);
        }
    }
}
