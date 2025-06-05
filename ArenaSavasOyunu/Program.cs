using System;

namespace ArenaSavasOyunu
{
    class Program
    {
        static void Main()
        {
            Console.Write("Oyuncu adını girin: ");
            string ad = Console.ReadLine();
            Oyuncu oyuncu = new Oyuncu(ad);

            Karakter[] dusmanlar = { new Zombi(), new Gulyabani(), new Ejderha() };
            int index = 0;
            int skor = 0;
            Karakter dusman = dusmanlar[index];

            while (oyuncu.Can > 0)
            {
                Console.WriteLine($"\n{oyuncu.Ad} - Can: {oyuncu.Can}, Mana: {oyuncu.Mana}");
                Console.WriteLine($"{dusman.Ad} - Can: {dusman.Can}, Mana: {dusman.Mana}");

                Console.WriteLine("1- Saldırı");
                Console.WriteLine("2- Özel Yetenek");
                Console.WriteLine("3- Mana Yenile");
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();

                if (secim == "1")
                    oyuncu.Saldir(dusman);
                else if (secim == "2")
                    oyuncu.OzelYetenek(dusman);
                else if (secim == "3")
                    oyuncu.ManaYenile();
                else
                {
                    Console.WriteLine("Geçersiz seçim, tur atlandı.");
                    continue;
                }

                if (dusman.Can > 0)
                {
                    if (dusman.Mana >= 100)
                        dusman.OzelYetenek(oyuncu);
                    else
                        dusman.Saldir(oyuncu);
                }
                else
                {
                    Console.WriteLine($"{dusman.Ad} yok edildi!");
                    skor += 100;
                    index++;
                    if (index < dusmanlar.Length)
                    {
                        dusman = dusmanlar[index];
                        Console.WriteLine($"{dusman.Ad} arenaya girdi!");
                    }
                    else
                    {
                        Console.WriteLine("Tüm canavarları yendiniz, kazandınız!");
                        break;
                    }
                }
            }

            if (oyuncu.Can <= 0)
                Console.WriteLine($"{oyuncu.Ad} öldü! Oyun bitti.");

            Console.WriteLine($"\nToplam Saldırı Sayısı: {Karakter.SaldiriSayisi}");
            Console.WriteLine($"Skor: {skor}");
        }
    }
}
