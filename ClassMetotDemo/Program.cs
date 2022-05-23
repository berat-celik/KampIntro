using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Berat";
            musteri1.Soyad = "Çelik";
            musteri1.TcNo = "12345678910";
            musteri1.Yas = 21;
            musteri1.Sifre = 1234;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Aleyna";
            musteri2.Soyad = "Teke";
            musteri2.TcNo = "11111111111";
            musteri2.Yas = 20;
            musteri2.Sifre = 4444;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Emre";
            musteri3.Soyad = "Parmaksız";
            musteri3.TcNo = "11111111111";
            musteri3.Yas = 23;
            musteri3.Sifre = 5555;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Güncelle(musteri2);
            musteriManager.Sil(musteri3);
            Console.WriteLine("****************");
            musteriManager.Listeleme(musteriler);



        }
    }
}
