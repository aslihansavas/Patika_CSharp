namespace csharp_enum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazar);
        Console.WriteLine((int)Gunler.Cumartesi);//numeric değerine ulaşmak için case işlemi yaptık

        int sicaklik=25;
        if (sicaklik<=(int)HavaDurumu.Normal)
        {
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyin");
        }
        else if (sicaklik>=(int)HavaDurumu.Sıcak)
        {
            Console.WriteLine("Dışarıya çıkmak için hava çok sıcak");
        }
        else if(sicaklik >=(int)HavaDurumu.Normal && sicaklik<=(int)HavaDurumu.Sıcak)
        {
            Console.WriteLine("hadi dışarıya çıkalım");
        }

    }
}
enum Gunler
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma =23, // buna 23 değerini atarsak cumartesi 24 pazar 25 ten devam eder.
    Cumartesi,
    Pazar
}
enum HavaDurumu
{
    Soguk =5 ,
    Normal=25,
    Sıcak=30


}
