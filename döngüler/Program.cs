

string kurs1 = "Yazılım Geliştirici Kampı";
string kurs2 = "Yazılım çukulata Kursu";
string kurs3 = "Yazalım Kazılım kurs";

//array - dizi

string[] kurslar = new string[] { "Yazılım Geliştirici Kampı","Yazılım çukulata Kursu","Yazalım Kazılım kurs","jkdfgjdk","bomba" };


for (int i = 0; i<kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For bitti");

// ister usttekı gıbı ıster alttakı gıbı yaz ıkısıde aynı anlamda
// yani for yada foreach metınlerını burda yazdıgım gıbı yazarsak aynı anlma gelır

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}


Console.WriteLine("sayfa sonu _ footer");
