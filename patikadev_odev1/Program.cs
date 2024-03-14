namespace patikadev_odev1;
using System;

class Program
{
    static void Main(string[] args)
    {



        /*
                    SORU 1
           Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
           Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
           Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 
        */
        /*
        int n;
        Console.WriteLine("POZİTİF BİR SAYI GİRİNİZ : ");
        n=Convert.ToInt32(Console.ReadLine());
        int[] sayilar=new int [n];
       
        for(int i=0;i<sayilar.Length;i++){
            Console.WriteLine(i+1 + ". sayıyı giriniz:");
           sayilar[i]= Convert.ToInt32(Console.ReadLine());
            
        }
        foreach (int  sayi in sayilar)
        {
            if(sayi%2==0)
            Console.WriteLine("girmiş olduğunuz sayiylardan çift olanlar : " + sayi);
        } */
        








        /* 
                    SORU 2
        Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
    
        */

        /*
        Console.WriteLine("1.sayıyı giriniz:");
        int sayi1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ikinci sayıyı giriniz :");
        int sayi2= Convert.ToInt32(Console.ReadLine());
        int[] sayilar=new int[sayi1];

         for(int i=0;i<sayilar.Length;i++){
            Console.WriteLine(i+1 + ". sayıyı giriniz:");
           sayilar[i]= Convert.ToInt32(Console.ReadLine());
            
        }
        foreach (int y  in sayilar)
        {
            if (y==sayi2 || y % sayi2==0)
            {
                Console.WriteLine("girmiş olduğunuz ilk sayiya eşit olan veya tam bölünen sayilar : " +  y);
            }
        }*/









        /*
                    SORU 3
        Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.  
        */
        /*
        Console.WriteLine("Bir sayı giriniz :");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] kelimeler = new string[n];
        for (int i = 0; i < kelimeler.Length; i++)
        {
            Console.WriteLine("Kelime giriniz : ");
            kelimeler[i]=Console.ReadLine();


        }
        for (int j = kelimeler.Length-1; j >=0 ; j--)
        {
            Console.WriteLine(kelimeler[j]);
        }*/


        /*
                        SORU 4
        Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        */
        Console.WriteLine("Bir cümle yazınız:");
        string cumle = Console.ReadLine();

        // Cümledeki kelime sayısını hesaplama
        int kelimeSayisi = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        // Cümledeki harf sayısını hesaplama
        int harfSayisi = cumle.Replace(" ", "").Length;

        Console.WriteLine($"Girilen cümledeki toplam kelime sayısı: {kelimeSayisi}");
        Console.WriteLine($"Girilen cümledeki toplam harf sayısı: {harfSayisi}");






    }
}
