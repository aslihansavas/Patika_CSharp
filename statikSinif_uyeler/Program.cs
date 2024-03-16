namespace statikSinif_uyeler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı :{0}",Calisan.CalisanNo);
        Calisan calisan =new Calisan("Ayşe","yılmaz","Ik");
        Console.WriteLine("Çalışan Sayısı : {0}",Calisan.CalisanNo);
        Islemler.Cikar(25,30); 


    }
}
class Calisan{
    private static int calisanNo;
    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calisan(){
        calisanNo=0;
    }
    public Calisan(string isim, string soyisim = null, string departman = null)
    {
        this.Isim=isim;
        this.Soyisim=soyisim;
        this.Departman=departman;
        calisanNo ++;
    }

    public static int CalisanNo { get => calisanNo; }

    
}
static class Islemler{
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2 ;

        }
        public static long Cikar(int sayi1,int sayi2 )
        {
            return sayi1 - sayi2 ;
        }
    }
