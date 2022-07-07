// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string adi = "hasan";
int yas = 34;

Kurs kurs1 = new Kurs();
kurs1.kursAdı = "C#";
kurs1.egitmen = "HAK";
kurs1.İzlenmeOranı = 99;

Kurs kurs2 = new Kurs();
kurs2.kursAdı = "cukuklata";
kurs2.egitmen = "HeK";
kurs2.İzlenmeOranı = 1229;

Kurs kurs3 = new Kurs();
kurs3.kursAdı = " kutu";
kurs3.egitmen = "gatr";
kurs3.İzlenmeOranı = 3499;

//Console.WriteLine(kurs1.kursAdı + " : " + kurs1.egitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.kursAdı + ":" + kurs.egitmen);
}

class Kurs
{
    public string kursAdı { get; set; }

    public string egitmen { get; set; }

    public int İzlenmeOranı { get; set; }
}
