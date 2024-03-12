using System.Runtime.CompilerServices;

namespace operatorler;

class Program
{
    static void Main(string[] args)
    {
        //ATAMA VE İŞLEMLİ ATAMA
        int x = 3;
        int y = 3 ;
        // atama  : 
        y = y + 2;
        // işlemli atama :
        y += 2;

        // Mantıksal Operatörler 
        // || , && , !
        
        bool  isSuccess = true ;
        bool isCompleted = false ;

        if (isSuccess && isCompleted)
                Console.WriteLine("Perfect !") ;
            
        
        if (isSuccess || isCompleted)
                Console.WriteLine("Great !") ;
            
        
        if (isSuccess && !isCompleted)
                Console.WriteLine("Fine") ; 
            
         //İlişkisel Operatörler 
         // <, >, <=, >=, ==, !=

         int a = 3;
         int b = 4;
         bool sonuc = a < b ;
         Console.WriteLine(sonuc);
         sonuc = a > b ;
         Console.WriteLine(sonuc);
         sonuc = a >= b ;
         Console.WriteLine(sonuc);
         sonuc = a <= b ;
         Console.WriteLine(sonuc);
         sonuc= a == b ;
         Console.WriteLine(sonuc);

         // Aritmetik Operatörler

         int sayi1 = 10 ;
         int sayi2 = 5 ;
         int sonuc1 = sayi1 / sayi2 ;
         Console.WriteLine(sonuc1);
         sonuc1= sayi1 * sayi2 ;
         Console.WriteLine(sonuc1);
         sonuc1 = sayi1 + sayi2 ;
         Console.WriteLine(sonuc1);
         sonuc1= sayi2 - sayi1 ;
         Console.WriteLine(sonuc1);
         sonuc1= sayi1++;
         int sonuc2 = 20%3;
         Console.WriteLine(sonuc2);

        
    }
}
