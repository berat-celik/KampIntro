using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.UrunAdi = "Diş Fırçası";
            urun1.UrunAciklamasi = "Şarjlı Diş Fırçası";
            urun1.UrunFiyati = 450;
            urun1.UrunResmi = "Diş Fırçası Resmi";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.UrunAdi = "Kol Saati";
            urun2.UrunAciklamasi = "Dijital saat";
            urun2.UrunFiyati = 13.99;
            urun2.UrunResmi = "Kol Saati Resmi";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.UrunAdi = "Çamaşır Makinası";
            urun3.UrunAciklamasi = "Enerji Tasarruflu";
            urun3.UrunFiyati = 5500;
            urun3.UrunResmi = "Çamaşır Makinası Resmi";

            Urun urun4 = new Urun();
            urun4.Id = 4;
            urun4.UrunAdi = "Tıraş Makinası";
            urun4.UrunAciklamasi = "Enerji Tasarruflu";
            urun4.UrunFiyati = 2500;
            urun4.UrunResmi = "Tıraş Makinası Resmi";


            Urun[] urunler = new Urun[] {urun1,urun2,urun3,urun4};

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürünün id'si: "+urunler[i].Id);
                Console.WriteLine("Ürünün Adı: " + urunler[i].UrunAdi);
                Console.WriteLine("Ürünün Fiyatı: " + urunler[i].UrunFiyati);
                Console.WriteLine("Ürünün Resmi: " + urunler[i].UrunResmi);
                Console.WriteLine("**********************************************");
            }
            Console.WriteLine("For Bitti");
            Console.WriteLine("  ");
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürünün id'si: " + urun.Id);
                Console.WriteLine("Ürünün Adı: " + urun.UrunAdi);
                Console.WriteLine("Ürünün Fiyatı: " + urun.UrunFiyati);
                Console.WriteLine("Ürünün Resmi: " + urun.UrunResmi);
                Console.WriteLine("*****************************************");

            }

            Console.WriteLine("Foreach bitti");
            Console.WriteLine(" ");
            int j = 0;

            while (j<urunler.Length)
            {
                Console.WriteLine("Ürünün id'si: " + urunler[j].Id);
                Console.WriteLine("Ürünün Adı: " + urunler[j].UrunAdi);
                Console.WriteLine("Ürünün Fiyatı: " + urunler[j].UrunFiyati);
                Console.WriteLine("Ürünün Resmi: " + urunler[j].UrunResmi);
                Console.WriteLine("**********************************************");


                j++;

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
