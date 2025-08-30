using System;

// Temel Hayvan sınıfı
public class Hayvan
{
    public string Isim { get; set; }
    public int Yas { get; set; }

    // Temel sınıfta her hayvanın ses çıkarabilmesi için bir metot var
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan ses çıkarıyor...");
    }

    // Temel sınıfın bir metodunu kullanarak hayvanın bilgilerini yazdırabiliriz
    public void BilgileriGoster()
    {
        Console.WriteLine($"Hayvanın ismi: {Isim}, Yaşı: {Yas}");
    }
}

// Kopek sınıfı, Hayvan sınıfından türemektedir
public class Kopek : Hayvan
{
    public string Irk { get; set; }

    // Kopek sınıfı, SesCikar metodunu override ederek kendine özgü bir ses çıkarır
    public override void SesCikar()
    {
        Console.WriteLine($"{Isim} hav hav!");
    }

    // Kopek sınıfına özel bir metot
    public void KopekOynamak()
    {
        Console.WriteLine($"{Isim} oyun oynamak istiyor.");
    }
}

// Kedi sınıfı, Hayvan sınıfından türemektedir
public class Kedi : Hayvan
{
    public string Renk { get; set; }

    // Kedi sınıfı, SesCikar metodunu override ederek kendine özgü bir ses çıkarır
    public override void SesCikar()
    {
        Console.WriteLine($"{Isim} miyav!");
    }

    // Kedi sınıfına özel bir metot
    public void KediYavasYavasYurur()
    {
        Console.WriteLine($"{Isim} yavaşça yürüyerek odada dolaşıyor.");
    }
}

// Kus sınıfı, Hayvan sınıfından türemektedir
public class Kus : Hayvan
{
    public string KanatTipi { get; set; }

    // Kus sınıfı, SesCikar metodunu override ederek kendine özgü bir ses çıkarır
    public override void SesCikar()
    {
        Console.WriteLine($"{Isim} cıv cıv!");
    }

    // Kus sınıfına özel bir metot
    public void KusUcmak()
    {
        Console.WriteLine($"{Isim} yükseklerde uçuyor!");
    }
}

// Program sınıfı
public class Program
{
    static void Main()
    {
        // Kopek nesnesi oluşturuluyor ve Hayvan sınıfının metotları kullanılıyor
        Kopek kopek1 = new Kopek { Isim = "Karabas", Yas = 5, Irk = "Doberman" };
        kopek1.BilgileriGoster();  // Temel sınıf metoduyla bilgileri göster
        kopek1.SesCikar();         // Alt sınıf metodunu çağır (override edilmiş)
        kopek1.KopekOynamak();     // Kopek sınıfına özel metot

        // Kedi nesnesi oluşturuluyor
        Kedi kedi1 = new Kedi { Isim = "Tekir", Yas = 3, Renk = "Beyaz" };
        kedi1.BilgileriGoster();  // Temel sınıf metoduyla bilgileri göster
        kedi1.SesCikar();         // Alt sınıf metodunu çağır (override edilmiş)
        kedi1.KediYavasYavasYurur();  // Kedi sınıfına özel metot

        // Kus nesnesi oluşturuluyor
        Kus kus1 = new Kus { Isim = "Sarı Kanarya", Yas = 2, KanatTipi = "Uzun Kanatlar" };
        kus1.BilgileriGoster();  // Temel sınıf metoduyla bilgileri göster
        kus1.SesCikar();         // Alt sınıf metodunu çağır (override edilmiş)
        kus1.KusUcmak();         // Kus sınıfına özel metot
    }
}
