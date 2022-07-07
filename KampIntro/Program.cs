// See https://aka.ms/new-console-template for more information
//type safey _ tip güvenliği
//do not repeat yourself - kendini tekrarlama
//değer tutucu  (alias) örneğin aşşağıdaki katagori etiketi



string katagoriEtiketi = "Katagoriler";
Console.WriteLine(katagoriEtiketi);
// dersek printa katagoriler yazar ve bu temız kod  
Console.WriteLine("katagoriler");
// bu ise yine printa katagoriler yazar ama tekli yazım , 
// bunla yapılırsa bir degısıklıkte tüm 
// böyle olan teklileri değiştirmek gerekir

int ogrenciSayısı = 3200;
double sapmaOranı = 1.14;
bool sistemeGirişYapmışMı = false;


double dolarDun = 7.55;
double dolarBugun = 7.65;

if (sistemeGirişYapmışMı == false)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış butonu");
}
else
{
    Console.WriteLine("değişmedi butonu");
}



Console.WriteLine("Hello, World!");