namespace constructor;

class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1=new Calisan("aslı","savaş");
    }
}
class Calisan{
    public string Ad;
    public string Soyad;

    public Calisan(string ad, string soyad)
    {
        this.Ad=ad;
        this.Soyad=soyad;

    }
}
