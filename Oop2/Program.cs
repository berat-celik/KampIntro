using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berat Çelik
            BireyselMusteri musteri1 = new BireyselMusteri(); //101
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Berat";
            musteri1.Soyadi = "Çelik";
            musteri1.TcNo = "12345678910";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri(); //102
            musteri2.Id = 1;
            musteri2.MusteriNo = "1234561";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "2222";

            Musteri musteri3 = new TuzelMusteri(); 
            Musteri musteri4 = new BireyselMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1); //101
            musteriManager.Add(musteri2); //102


        }
    }
}
