namespace siniflar;

class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1=new Calisan();
        calisan1.Ad="aslı";
        calisan1.Soyad="savaş";
        calisan1.No=98;
        calisan1.Departman="İnsan Kaynakalrı";
        calisan1.CalisanBilgileri();

    }
}
class Calisan{
    public string Ad;
    public string Soyad;
    public int No;

    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("çalışan adı :{0}",Ad);
        Console.WriteLine("çalışan soyadı :{0}",Soyad);
        Console.WriteLine("çalışan numarası :{0}",No);
        Console.WriteLine("çalışan departmanı :{0}",Departman);
    }

}
