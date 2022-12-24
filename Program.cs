class Program
{
    static void Main(string[] args)
    {
        // out parameter
        string sayi = "999";

        bool sonuc = int.TryParse(sayi,out int outSayi);
        if(sonuc)
        {
            Console.WriteLine("Başarılı");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("başarısız!");
        }

        Methods instance = new Methods();
        instance.Topla(2,3, out int toplamSonuc);
        Console.WriteLine(toplamSonuc);

        //Method Overloading (Aşırı yükleme)
        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);
        instance.EkranaYazdir("Tuna", "Köseler");
    }
}

class Methods
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
     public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}