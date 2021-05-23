using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" Müşteri Eklendi... Id: " + musteri.Id + " Adı: " + musteri.Adi + " Soyadı: " + musteri.SoyAdi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(" Müşteri Silindi... Id: " + musteri.Id + " Adı: " + musteri.Adi + " Soyadı: " + musteri.SoyAdi);
        }

        public void Listele(Musteri[] musteris)
        {
            foreach (var musteri in musteris)
            {
                Console.WriteLine("Id: " + musteri.Id + " Adı: " + musteri.Adi + " Soyadı: " + musteri.SoyAdi);
            }
        }
    }
}
