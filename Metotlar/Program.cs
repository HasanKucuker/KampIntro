// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");

// dont repeat yourself - DRY - cleanCode



string urunAdı = "elma";
double fiyatı= 15;
string aciklama = "Amasya elması";

string[] meyveler = new string[] { };

Urun urun1 = new Urun();
urun1.Adi = "elma";
urun1.Fiyatı = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "karpuz";
urun2.Fiyatı = 10;
urun2.Aciklama = "ıyı karpuz";

Urun[] urunler = new Urun[] { urun1, urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyatı);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("-----------");
}

Console.WriteLine("-------Metotlar---------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil armut", 12);
sepetManager.Ekle2("elma", "Yeşil elma", 32);
sepetManager.Ekle2("Karpuzzz", "Y karpuz", 992);
































