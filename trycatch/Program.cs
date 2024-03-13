namespace trycatch;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Hata alma ihtimali yüksek olan kod bloğu buraya yazılır.
            Console.WriteLine("Bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı : " + sayi );
        }
        /*catch (Exception ex)
        {
            // Herhangi bir hata ile karşılaştığımızda yapmak istediğimiz eylemler buraya yazılır.
            Console.WriteLine("Hata : " + ex.Message.ToString());
        
        }*/
        catch(FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun değil");
            Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("çok küçük ya da çok büyük bir değer girdiniz ");
            Console.WriteLine(ex);
        }
        finally
        {
            // Her durumda çalışacak kod bloğu - opsiyonel
            Console.WriteLine("işlem tamamlandı.");
        }



    }
}
