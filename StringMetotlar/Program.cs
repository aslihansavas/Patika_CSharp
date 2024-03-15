namespace StringMetotlar;

class Program
{
    static void Main(string[] args)
    {
        string degisken = "Dersimiz Csharp, Hoşgerldiniz ! ";
        string degisken2="Dersimiz Csharp";
        //Lenght : değişkenimiz de kaç karakter olduğunu bulır
        Console.WriteLine(degisken.Length);

        //ToUpper ToLower : büyük harfle ve küçük harfle ekrana yazma
        Console.WriteLine(degisken.ToLower());
        Console.WriteLine(degisken.ToUpper());

        //Concat : degisken ile başka bir metin birleştirme
        Console.WriteLine(String.Concat(degisken,"Merhaba"));
        

        //Compare ,CompareTo : karşılaştırma
        Console.WriteLine(degisken.CompareTo(degisken2)); 
        // birinci değişken ikinci değişkene eşit olursa 0 döner
        //birinci değişken ikinci değişkenden daha büyük karakter sayısına sahipse 1 döndürür
        //birinci değişken ikinci değişkenden daha küçük karakter sayısına sahipse -1 döndürür.

        //Compare
        Console.WriteLine(String.Compare(degisken,degisken2,true)); //ignorecass = true büyük küçük harf duyarlı değil
        Console.WriteLine(String.Compare(degisken,degisken2,false));//false = büyük  küçük harf duyarlı 

        //Contains
        Console.WriteLine(degisken.Contains(degisken2));//degiskennin içinde degisken2 var mı ? bulursa true döndürür.
        Console.WriteLine(degisken.EndsWith("hoşgeldiniz !")); //hoşgeldiniz kelimesiyle bitiyor mu ?
        Console.WriteLine(degisken.StartsWith("merhaba"));//merhaba ile başlıyor mu ?

        //indexof
        Console.WriteLine(degisken.IndexOf("CS")); // degiskenin içinde verdiğimiz metinsel ifadeyi arayacak bulduğu ilk yerde ilk karakterin indeks numarasını dönürecek
        Console.WriteLine(degisken.IndexOf("asli")); // hiçbir şey bulamadığında -1 döndürür.
 Console.WriteLine(degisken.LastIndexOf("i")); //i nin bulunduğu son indeksi getirir.
        //insert
        Console.WriteLine(degisken.Insert(0,"merhaba !")); // 0. indeksten başlar ve kelimeyi ekler

        //PadLeft, PadRight
        Console.WriteLine(degisken + degisken2.PadLeft(30));
        Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
        Console.WriteLine(degisken.PadRight(50) + degisken2);
        Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

        //remove
        Console.WriteLine(degisken.Remove(10)); // 10. indeksten sonrasını siler sadece 10. indekse kadar gteiriri.
        Console.WriteLine(degisken.Remove(5,3));//5. indeksten sonra 3 karakter sildi
        Console.WriteLine(degisken.Remove(0,1));// en baştaki indeks değerini sildi

        //Replace
        Console.WriteLine(degisken.Replace("CSharp","C#"));
        Console.WriteLine(degisken.Replace(" ","*"));//boşlukları yıldızla değiştir

        //SPLİT
        Console.WriteLine(degisken.Split(' ')[1]); //verilen metinleri boşluklardan parçalara ayır ve diziye ata ve bana 1. indeksteki değeri getir.

        //Substring
        Console.WriteLine(degisken.Substring(4)); //4. indeksten başlayarak sonuna kadar degiskeni getir.

        Console.WriteLine(degisken.Substring(4,6)); //4. indeksten başlayarak 6 karakter getir.

    }
}
