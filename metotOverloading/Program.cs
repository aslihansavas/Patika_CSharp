using System.ComponentModel;

namespace metotOverloading;

class Program
{
    static void Main(string[] args)
    {
       //out parametreler
       string sayi ="999";

       bool sonuc = int.TryParse(sayi,out int outSayi);
       if(sonuc)
       {
        Console.WriteLine("başarılı");
        Console.WriteLine(outSayi);
       }
       else
       Console.WriteLine("başarısız");
       Metotlar instance =new Metotlar();
       instance.Topla(4,5,out int toplamsonucu);
       Console.WriteLine(toplamsonucu);

       //metot aşırı yükleme - overloading
       int ifade=999;
       instance.EkranaYazdir(Convert.ToString(ifade));
       // Metot imzası 
       // metotadı + parametre sayisi + parametre
       instance.EkranaYazdir(ifade);
       instance.EkranaYazdir("aslihan","savaş");
       
    

    }
    
}
class Metotlar
{
    public void Topla(int a, int b, out int toplam){
        toplam=a+b;
    }   
    
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2){
        Console.WriteLine(veri1 + veri2);
    }
}
