using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();  //Class'tan değişken tanımlayacağım zaman onu new'lememgerekiyor böyle. Burada Musteri bir classtır. 
            musteri1.FisrtName = "Nedim";
            musteri1.LastName = "Karataş";
            musteri1.ID = 1;
            musteri1.Meslek = "Modelci";
            musteri1.MusteriNo = 123;
            musteri1.TelNo = 123456;

            Musteri musteri2 = new Musteri();
            musteri2.FisrtName = "Nazlı";
            musteri2.LastName = "Karataş";
            musteri2.ID = 2;
            musteri2.Meslek = "PY";
            musteri2.MusteriNo = 124;
            musteri2.TelNo=1234562;

            Musteri musteri3 = new Musteri();
            musteri3.FisrtName = "Yusuf";
            musteri3.LastName = "Gün";
            musteri3.ID = 2;
            musteri3.Meslek = "Programcı";
            musteri3.MusteriNo = 125;
            musteri3.TelNo= 456125;


            Musteri musteri4 = new Musteri();
            musteri4.FisrtName = "Güler";
            musteri4.LastName = "Kara";
            musteri4.ID = 2;
            musteri4.Meslek = "Öğrenci";
            musteri4.MusteriNo = 126;
            musteri4.TelNo= 3698521;

            Console.WriteLine("***********************EKLE*********************");
            MusteriManager musteriManager = new MusteriManager();
            List<Musteri> musteriler = new List<Musteri>();

            musteriManager.Ekle(ref musteriler, musteri1);
            musteriManager.Ekle(ref musteriler, musteri2);
            musteriManager.Ekle(ref musteriler, musteri3);
            musteriManager.Ekle(ref musteriler, musteri4);

            Console.WriteLine("************************************************");
            Console.WriteLine("---------------------------lİSTELE-------------------------------");

            foreach (Musteri x in musteriler)
            {
                Console.WriteLine(x.FisrtName);
            }

            Console.WriteLine("--------------------------SİL--------------------------------");

            musteriManager.Sil(ref musteriler, musteri4);

            Console.WriteLine("----------------------SİLDİKTEN SONRA LİSTELE------------------------------------");
            foreach (Musteri x in musteriler)
            {
                Console.WriteLine(x.FisrtName);
            }

           



        }


    }
}
