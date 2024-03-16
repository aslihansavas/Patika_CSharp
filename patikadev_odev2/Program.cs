using System.Collections;

namespace patikadev_odev2;

class Program
{
    public static bool isPrime(int sayi){
        if (sayi <= 1) {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(sayi); i++) {
            if (sayi % i == 0) {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        /*
          1.soru 
           Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
        */

       
        
        ArrayList prime = new ArrayList();
        ArrayList notPrime=new ArrayList();
        for (int i = 0; i <=20; i++)
        {   bool isValidInput = false ;
            int sayi=0;
            while (!isValidInput) {
                Console.Write($"sayi giriniz : {i + 1}: ");
                string input = Console.ReadLine();

                // Sayısal olup olmadığını ve negatif olup olmadığını kontrol et
                if (int.TryParse(input, out sayi) && sayi > 0) {
                    isValidInput = true;
                } else {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }
           
           if(isPrime(sayi)==true)
           {
                prime.Add(sayi);
           }
           else
           {
                notPrime.Add(sayi);
           }
               
        }
        prime.Sort();
        prime.Reverse();
        notPrime.Sort();
        notPrime.Reverse();
        int primesum=0;
        int notprimesum = 0;
        foreach (int primes in prime )
        {
            primesum +=primes;
            Console.WriteLine("******* Girilen asal sayılar : ********");
            Console.WriteLine(primes);


        }
        foreach(int notprimes in notPrime)
        {
            notprimesum += notprimes;
            Console.WriteLine("*********** Girilen Asal Olmayan sayılar ********" );
            Console.WriteLine(notprimes);
        }
        Console.WriteLine("Toplam Asal sayıların sayısı :" + prime.Count);
        Console.WriteLine("Asal sayılar ortalaması :" + primesum / prime.Count);
        Console.WriteLine("Toplam Asal Olmayan sayıların sayısı : " + notPrime.Count);
        Console.WriteLine("Asal olmayan sayıların ortalaması : " + notprimesum / notPrime.Count);

         /* 
        2. soru : Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
        her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
        (Array sınıfını kullanarak yazınız.)
        */
     
        ArrayList list = new ArrayList();
        for (int i = 0; i < 20; i++)
        {
            int number=0;
            Console.WriteLine(i +1 + ".sayıyı giriniz :");
            number=Convert.ToInt32(Console.ReadLine());
            list.Add(number);
        }

        list.Sort();
        list.Reverse();

        int maxSum = 0;
        Console.WriteLine("Largest 3 numbers:");
        for (int i = 0; i < 3; i++) {
            int num = (int)list[i];
            Console.WriteLine(num);
            maxSum += num;
        }

        int minSum = 0;
        Console.WriteLine("Smallest 3 numbers:");
        for (int i = list.Count - 1; i >= list.Count - 3; i--) {
            int num = (int)list[i];
            Console.WriteLine(num);
            minSum += num;
        }

         // Ortalama hesaplama ve yazdırma
        double maxAverage = (double)maxSum / 3;
        double minAverage = (double)minSum / 3;

        Console.WriteLine($"Average of largest 3 numbers: {maxAverage}");
        Console.WriteLine($"Average of smallest 3 numbers: {minAverage}");
        Console.WriteLine($"Total sum of largest 3 numbers: {maxSum}");
        Console.WriteLine($"Total sum of smallest 3 numbers: {minSum}");



    


    }


   

}
