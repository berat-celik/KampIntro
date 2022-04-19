using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.UrunAdi = "Laptop";
            urun1.UrunFiyati = 12500;
            urun1.UrunAciklamasi = "Monster Bilgisayar";
            urun1.UrunResmi = "Laptop Resmi";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.UrunAdi = "Çamaşır Makinası";
            urun2.UrunFiyati = 5600;
            urun2.UrunAciklamasi = "Enerji Tasarrufflu";
            urun2.UrunResmi = "Çamaşır Makinası Resmi";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.UrunAdi = "Gözlük";
            urun3.UrunFiyati = 700;
            urun3.UrunAciklamasi = "İyi bir marka";
            urun3.UrunResmi = "Gözlük Resmi";


            Urun[] urunler = new Urun[] {urun1,urun2,urun3};

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürünün id'si: " + urunler[i].Id);
                Console.WriteLine("Ürünün Adı: "+ urunler[i].UrunAdi);
                Console.WriteLine("Ürünün Fiyatı: "+ urunler[i].UrunFiyati);
                Console.WriteLine("Ürünün Açıklaması: "+ urunler[i].UrunAciklamasi);
                Console.WriteLine("Ürünün Resmi: "+ urunler[i].UrunResmi);
                Console.WriteLine("*********************************************");
            }




            Console.WriteLine("For döngüsü bitti");

            int j = 0;

            while (j<urunler.Length)
            {
                Console.WriteLine("Ürünün id'si: " + urunler[j].Id);
                Console.WriteLine("Ürünün Adı: " + urunler[j].UrunAdi);
                Console.WriteLine("Ürünün Fiyatı: " + urunler[j].UrunFiyati);
                Console.WriteLine("Ürünün Açıklaması: " + urunler[j].UrunAciklamasi);
                Console.WriteLine("Ürünün Resmi: " + urunler[j].UrunResmi);
                Console.WriteLine("*********************************************");
                j++;


            }

            Console.WriteLine("While döngüsü bitti");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürünün id'si: " + urun.Id);
                Console.WriteLine("Ürünün Adı: " + urun.UrunAdi);
                Console.WriteLine("Ürünün Fiyatı: " + urun.UrunFiyati);
                Console.WriteLine("Ürünün Açıklaması: " + urun.UrunAciklamasi);
                Console.WriteLine("Ürünün Resmi: " + urun.UrunResmi);
                Console.WriteLine("*********************************************");

            }
                
        }
       
    }

    class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public string UrunAciklamasi { get; set; }
        public string UrunResmi { get; set; }

    }

    


   
}
