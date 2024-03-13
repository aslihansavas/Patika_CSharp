namespace tipdonusumleri;

class Program
{
    static void Main(string[] args)
    {
        // Implict Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine(("****** Implicit Conversion *****"));
            byte a = 5 ;
            sbyte b = 30 ;
            short c = 10;

            int d = a + b + c ;
            Console.WriteLine("d : " + d );

            long h = d ;
            Console.WriteLine("h : " + h );

            float i = h ;
            Console.WriteLine("i : " + i );

            string e = "asli";
            char f ='k';
            object g = e + f + d ;
            Console.WriteLine("g : " + g );




        //Explicit Conversion (Bilinçli ya da açık dönüşüm)
        Console.WriteLine(("****** Explicit Conversion *****"));
        int x = 4 ;
        byte y = (byte)x ; 
        Console.WriteLine("y : " + y );

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v : " + v );

        //ToString Methodu
        Console.WriteLine("****** ToString Metodu ******");
        int sayi = 6 ;
        string kelime1 = sayi.ToString();
        Console.WriteLine("kelime 1 : " + kelime1 );

        string fkelime = 12.5f.ToString();
        Console.WriteLine("fkelime : " + fkelime );

        //System.Convert
        Console.WriteLine("****** System.Convert ******");
        string s1 = "10";
        string s2 = "20";
        int sayi1, sayi2;
        int toplam;
        sayi1=Convert.ToInt32(s1);
        sayi2=Convert.ToInt32(s2);
        toplam = sayi1 + sayi2 ;
        Console.WriteLine("Toplam : " + toplam );

        //Parse

        Console.WriteLine("****** Parse Methodu ******");
        string metin1 = "10 ";
        string metin2 = "10.25";
        int rakam1;
        double double1;

        rakam1 = Int32.Parse(metin1);
        double1 = Double.Parse(metin2);
        Console.WriteLine("rakam 1 : " + rakam1);
        Console.WriteLine("double 1 : " + double1);


        
    }
}
