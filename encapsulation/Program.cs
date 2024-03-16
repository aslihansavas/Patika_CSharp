namespace encapsulation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
class Ogrenci{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    { get => sinif; 
      set {
        if(value <1 )
        {
            Console.WriteLine("sınıf en az 1 olabilir");
            sinif=1;
        }
        else
        {
            sinif=value;
        }
      } }
    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("***** ogrenci bilgileri****** ");
        Console.WriteLine("ogrenci adi : {0}",this.Isim);
        Console.WriteLine("öğrenci soyad :{0}",this.Soyisim);
        Console.WriteLine("öğrenci no :{0}",this.OgrenciNo);
        Console.WriteLine("öğrenci sınıf : {0}",this.Sinif);
    }
    public void SinifAtlat(){
        this.Sinif=this.Sinif+1;
    }
    public void SinifDusur(){
        this.Sinif=this.Sinif -1 ;
    }

}