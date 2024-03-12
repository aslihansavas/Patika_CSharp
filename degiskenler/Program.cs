namespace degiskenler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        byte b = 5;     // 1 byte
        sbyte c = 5;    // 1 byte

        short s = 5;    // 2 byte
        ushort us = 5;  // 2 byte

        Int16 i16 = 2;    // 2 byte
        int i = 2;        // 4 byte
        Int32 i32 = 2;    // 4 byte
        Int64 i64 = 2;   //8 byte

        uint ui = 2;    //4 byte
        long l = 4;    //8 byte
        ulong ul = 4;  //8 byte

        float f = 5;   //4 byte
        double d = 5;  //8 byte
        decimal dc = 5; //16 byte

        char ch = '2'; //2 byte
        string str = "hello"; //sınırsız

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        object o1= "x";
        object o2 ="y";
        object o3 = 4;
        object o4 =4.3;

        // STRİNG İFADELER

        string str1 = string.Empty;
        str1="aslıhan savaş";
        string ad= "aslıhan";
        string soyad = "savaş";
        string tamisim= ad +" "+soyad;

        //Integer İfadeler
        int sayi1 = 1;
        int sayi2 = 2;
        int toplam = sayi1 + sayi2;

        // Boolean
        bool bool1 = 10 < 2; //false
        bool bool2 = 2 < 10; //true

        //Değişken Dönüşümleri
        string str20 = "20";
        int int20 = 20 ;
        string yenideger = str20 + int20.ToString();

        int deger = int20 +Convert.ToInt32(str20);

        int dger2 = int20 + int.Parse(str20);

        //DateTime 
        string datetime = DateTime.Now.ToString("dd.MM.yyyy"); // day.month.year
        string hour = DateTime.Now.ToString("HH:mm"); //hour:minute






    }
}
