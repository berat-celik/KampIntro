using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi...");
            Console.WriteLine("Hoş geldiniz Sayın: "+musteri.Soyad);

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi...");

            Console.WriteLine("Silinen Müşteri Sayın: "+musteri.Soyad);

        }

        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi");
            Console.WriteLine("Güncellenen Müşteri Sayın: "+ musteri.Soyad);

        }

        public void Listeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri İsmi: "+musteri.Adi);

            }
            

        }
    }
}
