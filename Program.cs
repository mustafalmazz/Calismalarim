using System;

class Program
{
    static void Main()
    {
        int bakiye = 1000;
        while (true)
        {
            Console.WriteLine("\nATM'ye Hoş Geldiniz!");
            Console.WriteLine("1. Bakiye Görüntüle");
            Console.WriteLine("2. Para Çek");
            Console.WriteLine("3. Para Yatır");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminiz: ");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine($"Mevcut Bakiyeniz: {bakiye} TL");
                    break;
                case 2:
                    Console.Write("Çekmek istediğiniz tutarı girin: ");
                    int cekilecekTutar = int.Parse(Console.ReadLine());
                    if (cekilecekTutar > bakiye)
                    {
                        Console.WriteLine("Yetersiz bakiye!");
                    }
                    else
                    {
                        bakiye -= cekilecekTutar;
                        Console.WriteLine($"Yeni bakiyeniz: {bakiye} TL");
                    }
                    break;
                case 3:
                    Console.Write("Yatırmak istediğiniz tutarı girin: ");
                    int yatirilacakTutar = int.Parse(Console.ReadLine());
                    bakiye += yatirilacakTutar;
                    Console.WriteLine($"Yeni bakiyeniz: {bakiye} TL");
                    break;
                case 4:
                    Console.WriteLine("Çıkış yapılıyor. İyi günler!");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                    break;
            }
        }
    }
}
