using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_ToDo_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");

                int secim;
                if (!int.TryParse(Console.ReadLine(), out secim) || secim < 1 || secim > 4)
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen 1 ile 4 arasında bir sayı seçiniz.");
                    continue;
                }

                switch (secim)
                {
                    case 1:
                        board.Listele();
                        break;
                    case 2:
                        board.KartEkle();
                        break;
                    case 3:
                        board.KartSil();
                        break;
                    case 4:
                        board.KartTasi();
                        break;
                }
            }
        }
    }

    enum Buyukluk
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }

    class Kisi
    {
        public int ID { get; set; }
        public string Ad { get; set; }

        public Kisi(int id, string ad)
        {
            ID = id;
            Ad = ad;
        }
    }

    class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public Kisi AtananKisi { get; set; }
        public Buyukluk Buyukluk { get; set; }

        public Kart(string baslik, string icerik, Kisi atananKisi, Buyukluk buyukluk)
        {
            Baslik = baslik;
            Icerik = icerik;
            AtananKisi = atananKisi;
            Buyukluk = buyukluk;
        }
    }

    class Line
    {
        public List<Kart> Kartlar { get; set; }

        public Line()
        {
            Kartlar = new List<Kart>();
        }
    }

    class Board
    {
        public List<Line> Lines { get; set; }
        public List<Kisi> TakimUyeleri { get; set; }

        public Board()
        {
            Lines = new List<Line>
            {
                new Line(), // TODO
                new Line(), // IN PROGRESS
                new Line()  // DONE
            };

            TakimUyeleri = new List<Kisi>
            {
                new Kisi(1, "Ahmet"),
                new Kisi(2, "Ayşe"),
                new Kisi(3, "Mehmet"),
                new Kisi(4, "Fatma")
            };
        }

        public void KartEkle()
        {
            Console.WriteLine("Başlık Giriniz: ");
            string baslik = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz: ");
            string icerik = Console.ReadLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5): ");
            if (!Enum.TryParse(Console.ReadLine(), out Buyukluk buyukluk) || !Enum.IsDefined(typeof(Buyukluk), buyukluk))
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                return;
            }

            Console.WriteLine("Atanan Kişi ID'sini Seçiniz: ");
            int atananKisiID;
            if (!int.TryParse(Console.ReadLine(), out atananKisiID))
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                return;
            }

            Kisi atananKisi = TakimUyeleri.FirstOrDefault(k => k.ID == atananKisiID);
            if (atananKisi == null)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                return;
            }

            Lines[0].Kartlar.Add(new Kart(baslik, icerik, atananKisi, buyukluk));
        }

        public void KartSil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();

            Kart kart = Lines.SelectMany(line => line.Kartlar).FirstOrDefault(k => k.Baslik == baslik);
            if (kart == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int secim;
                if (!int.TryParse(Console.ReadLine(), out secim) || secim != 2)
                    return;
            }
            else
            {
                foreach (var line in Lines)
                {
                    line.Kartlar.RemoveAll(k => k.Baslik == baslik);
                }

                Console.WriteLine("Kart başarıyla silindi.");
            }
        }

        public void KartTasi()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string baslik = Console.ReadLine();

            Kart kart = Lines.SelectMany(line => line.Kartlar).FirstOrDefault(k => k.Baslik == baslik);
            if (kart == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int secim;
                if (!int.TryParse(Console.ReadLine(), out secim) || secim != 2)
                    return;
            }
            else
            {
                Console.WriteLine($"Bulunan Kart Bilgileri:\n**************************************\nBaşlık: {kart.Baslik}\nİçerik: {kart.Icerik}\nAtanan Kişi: {kart.AtananKisi.Ad}\nBüyüklük: {kart.Buyukluk}\nLine: {Lines.FindIndex(line => line.Kartlar.Contains(kart)) + 1}");

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");
                int hedefLineIndex;
                if (!int.TryParse(Console.ReadLine(), out hedefLineIndex) || hedefLineIndex < 1 || hedefLineIndex > 3)
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız!");
                    return;
                }

                if (hedefLineIndex - 1 == Lines.FindIndex(line => line.Kartlar.Contains(kart)))
                {
                    Console.WriteLine("Kart zaten seçtiğiniz Line'da bulunmaktadır.");
                    return;
                }

                Lines[hedefLineIndex - 1].Kartlar.Add(kart);
                Lines[Lines.FindIndex(line => line.Kartlar.Contains(kart))].Kartlar.Remove(kart);
                Console.WriteLine("Kart başarıyla taşındı.");
            }
        }

        public void Listele()
        {
            string[] lineNames = { "TODO", "IN PROGRESS", "DONE" };

            for (int i = 0; i < Lines.Count; i++)
            {
                Console.WriteLine($"\n{lineNames[i]} Line\n************************");

                if (Lines[i].Kartlar.Count == 0)
                {
                    Console.WriteLine("~ BOŞ ~");
                    continue;
                }

                foreach (var kart in Lines[i].Kartlar)
                {
                    Console.WriteLine($"Başlık: {kart.Baslik}\nİçerik: {kart.Icerik}\nAtanan Kişi: {kart.AtananKisi.Ad}\nBüyüklük: {kart.Buyukluk}");
                    Console.WriteLine("-");
                }
            }
        }
    }

    
}
