using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonRehberi rehber = new TelefonRehberi();
            rehber.VarsayilanNumaralariEkle();

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");

                int secim;
                if (!int.TryParse(Console.ReadLine(), out secim) || secim < 1 || secim > 5)
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen 1 ile 5 arasında bir sayı seçiniz.");
                    continue;
                }

                switch (secim)
                {
                    case 1:
                        rehber.YeniNumaraKaydet();
                        break;
                    case 2:
                        rehber.NumaraSil();
                        break;
                    case 3:
                        rehber.NumaraGuncelle();
                        break;
                    case 4:
                        rehber.RehberiListele();
                        break;
                    case 5:
                        rehber.RehberdeAramaYap();
                        break;
                }
            }
        }
    }

    class TelefonRehberi
    {
        private List<Kisi> rehber;

        public TelefonRehberi()
        {
            rehber = new List<Kisi>();
        }

        public void VarsayilanNumaralariEkle()
        {
            rehber.Add(new Kisi("Ahmet", "Yılmaz", "1234567890"));
            rehber.Add(new Kisi("Ayşe", "Kara", "2345678901"));
            rehber.Add(new Kisi("Mehmet", "Demir", "3456789012"));
            rehber.Add(new Kisi("Fatma", "Şahin", "4567890123"));
            rehber.Add(new Kisi("Ali", "Yıldırım", "5678901234"));
        }

        public void YeniNumaraKaydet()
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string telefon = Console.ReadLine();

            rehber.Add(new Kisi(isim, soyisim, telefon));
            Console.WriteLine("Yeni numara başarıyla kaydedildi.");
        }

        public void NumaraSil()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string aranan = Console.ReadLine();

            var bulunanKisi = rehber.FirstOrDefault(k => k.Isim == aranan || k.Soyisim == aranan);
            if (bulunanKisi == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");

                int secim;
                if (!int.TryParse(Console.ReadLine(), out secim) || secim != 2)
                    return;
            }
            else
            {
                Console.WriteLine($"{bulunanKisi.Isim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    rehber.Remove(bulunanKisi);
                    Console.WriteLine("Kişi başarıyla silindi.");
                }
            }
        }

        public void NumaraGuncelle()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string aranan = Console.ReadLine();

            var bulunanKisi = rehber.FirstOrDefault(k => k.Isim == aranan || k.Soyisim == aranan);
            if (bulunanKisi == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için: (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");

                int secim;
                if (!int.TryParse(Console.ReadLine(), out secim) || secim != 2)
                    return;
            }
            else
            {
                Console.WriteLine($"{bulunanKisi.Isim} isimli kişinin yeni telefon numarasını giriniz:");
                string yeniTelefon = Console.ReadLine();
                bulunanKisi.Telefon = yeniTelefon;
                Console.WriteLine("Telefon numarası başarıyla güncellendi.");
            }
        }

        public void RehberiListele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            foreach (var kisi in rehber.OrderBy(k => k.Isim))
            {
                Console.WriteLine($"İsim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, Telefon Numarası: {kisi.Telefon}");
            }
        }

        public void RehberdeAramaYap()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int secim;
            if (!int.TryParse(Console.ReadLine(), out secim) || (secim != 1 && secim != 2))
            {
                Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 seçiniz.");
                return;
            }

            Console.WriteLine("Arama yapmak istediğiniz kelimeyi giriniz:");
            string aranan = Console.ReadLine();

            List<Kisi> sonuclar;
            if (secim == 1)
                sonuclar = rehber.Where(k => k.Isim.Contains(aranan) || k.Soyisim.Contains(aranan)).ToList();
            else
                sonuclar = rehber.Where(k => k.Telefon.Contains(aranan)).ToList();

            if (sonuclar.Count == 0)
            {
                Console.WriteLine("Arama sonuçlarına uygun veri bulunamadı.");
            }
            else
            {
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");

                foreach (var kisi in sonuclar)
                {
                    Console.WriteLine($"İsim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, Telefon Numarası: {kisi.Telefon}");
                }
            }
        }
    }

    class Kisi
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Telefon { get; set; }

        public Kisi(string isim, string soyisim, string telefon)
        {
            Isim = isim;
            Soyisim = soyisim;
            Telefon = telefon;
        }
    }
}
