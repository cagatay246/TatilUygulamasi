using System;

class Program
{
    static void Main(string[] args)
    {
        bool devamEt = true;

        while (devamEt)
        {
            // Lokasyonlar ve fiyatları
            Console.WriteLine("3 ADET LOKASYONUMUZ VAR:");
            Console.WriteLine("1- Bodrum başlangıç fiyatı 4000 TL");
            Console.WriteLine("2- Marmaris başlangıç fiyatı 3000 TL");
            Console.WriteLine("3- Çeşme başlangıç fiyatı 5000 TL");

            // Kullanıcıdan lokasyon girişi almak
            Console.WriteLine("Hangi lokasyonu tercih edersiniz?");
            string lokasyon = Console.ReadLine().ToLower();

            // Kullanıcıdan kişi sayısı almak
            Console.WriteLine("Kaç kişi gitmeyi planlıyorsunuz?");
            int kisi = 0;
            while (!int.TryParse(Console.ReadLine(), out kisi) || kisi <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir kişi sayısı girin.");
            }

            // Lokasyon açıklaması
            if (lokasyon == "bodrum")
            {
                Console.WriteLine("Bodrum, güzel plajları, gece hayatı ve tarihi mekanları ile ünlüdür.");
            }
            else if (lokasyon == "çeşme")
            {
                Console.WriteLine("Çeşme, temiz plajları, sularının sıcaklığı ve huzurlu atmosferi ile bilinir.");
            }
            else if (lokasyon == "marmaris")
            {
                Console.WriteLine("Marmaris, doğası, plajları ve su sporları aktiviteleri ile popülerdir.");
            }
            else
            {
                Console.WriteLine("Geçersiz konum girdiniz, tekrar deneyin.");
                break;
            }

            Console.WriteLine("---------------------------------------------------------------");

            // Kullanıcıdan ulaşım aracı seçimi almak
            Console.WriteLine("Tatilinizi hangi ulaşım aracı ile yapmayı düşünüyorsunuz?");
            Console.WriteLine("1- Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
            Console.WriteLine("2- Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

            int ulasimtutari = 0;
            int secim = 0;
            while (true)
            {
                Console.WriteLine("Lütfen hangi ulaşım aracını istediğinizi rakam ile yazın (1 ya da 2):");
                if (int.TryParse(Console.ReadLine(), out secim) && (secim == 1 || secim == 2))
                {
                    if (secim == 1)
                    {
                        ulasimtutari = 1500; // Kara yolu
                    }
                    else if (secim == 2)
                    {
                        ulasimtutari = 4000; // Hava yolu
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim yaptınız. Lütfen 1 veya 2 giriniz.");
                }
            }

            // Lokasyon fiyatları
            int lokasyonFiyati = 0;
            if (lokasyon == "bodrum")
            {
                lokasyonFiyati = 4000;
            }
            else if (lokasyon == "marmaris")
            {
                lokasyonFiyati = 3000;
            }
            else if (lokasyon == "çeşme")
            {
                lokasyonFiyati = 5000;
            }

            // Toplam fiyat hesaplama
            double toplamFiyat = (lokasyonFiyati + ulasimtutari) * kisi;

            
            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine($"Gitmek istediğiniz lokasyon: {lokasyon}");
            Console.WriteLine($"Kişi sayısı: {kisi}");
            Console.WriteLine($"Ulaşım türü: {(secim == 1 ? "Kara yolu" : "Hava yolu")}");
            Console.WriteLine($"Lokasyon fiyatı: {lokasyonFiyati} TL");
            Console.WriteLine($"Ulaşım fiyatı: {ulasimtutari} TL");
            Console.WriteLine($"Toplam fiyat: {toplamFiyat} TL");

            // Kullanıcıya başka bir tatil planlamak isteyip istemediğini soruyoruz
            Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (Evet/Hayır)");
            string cevap = Console.ReadLine().ToLower();

            if (cevap == "evet")
            {
               
                devamEt = true;
            }
            else
            {
                
                Console.WriteLine("\nFiyatları tekrar görmek ister misiniz? (Evet/Hayır)");
                string tekrarCevap = Console.ReadLine().ToLower();

                if (tekrarCevap == "evet")
                {
                    
                    devamEt = true;
                }
                else
                {
                    // Hayır derse program sonlanır
                    Console.WriteLine("İyi günler!");
                    devamEt = false;
                }
            }
        }
    }
}