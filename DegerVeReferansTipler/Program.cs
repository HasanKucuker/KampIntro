// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hasaaaaaannnn");

        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        //sayi1  ??       30

        int[] sayilar1 = new int[] { 10, 20, 30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        // sayilar1[0]  ??         999

        // int , derimol , floot , double , bool = deger tip
        // array , class , interface = referans tip

        // yani dger tiplerde eşitleme atama 1 kere olur
        // referans tiplerde ise atama yapınca artık o diziye yeni bir
        // atama yapılana kadar bağlı kalır.

    }
}
























Console.WriteLine("Hello, World!");




