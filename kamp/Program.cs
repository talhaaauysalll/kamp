using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id =1;
            urun1.Adi = "Elma";
            urun1.Fiyati =15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            
            //type safe => Tip güvenli bir dildir...
            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Listelenen Ürünün Adı :"+urun.Adi);
                Console.WriteLine("Listelenen Ürünün Fiyati :"+urun.Fiyati);
                Console.WriteLine("Listelenen Ürünün Açıklaması :"+urun.Aciklama);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("----------------Metotlar-------------------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);




        }
    }// tekrar tekrar kod yazmamaya olanak sağlar...
    /*
     * dry kendini tekrar etme
       */
}
