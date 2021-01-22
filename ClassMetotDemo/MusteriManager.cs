using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Sonu Manager olan sınıflar görürsek; bunlar bir operasyon tutuyor demek. 
        //naming convention: İsimlendirme kuralları
        public void Ekle(ref List<Musteri> musteriler, Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine($"{musteri.FisrtName} adlı müşteri başarıyla eklendi.");
            
        }

        public string Liste(Musteri musteri)
        {

            string deger = musteri.FisrtName + musteri.MusteriNo + musteri.TelNo;
            return deger;
        }

        public void Sil(ref List<Musteri> musteriler, Musteri musteri)
        {
            musteriler.RemoveAll(p => p.FisrtName == musteri.FisrtName);
            Console.WriteLine($"{musteri.FisrtName} adlı müşteri başarıyla silindi.");
            

        }

        
    }
}
