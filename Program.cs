
 using System;
 using System.Collections.Generic;

public partial class Program
{
    static void Main()
    {
        // 1. Ödev: Yaş Kategorisini Belirleme
        Console.WriteLine(YasKategoriBelirle(25));
        Console.WriteLine(YasKategoriBelirle(40));
        Console.WriteLine(YasKategoriBelirle(80));

        // 2. Ödev: Araba Yaşı ve Durumu
        Console.WriteLine(ArabaDurumu(5));
        Console.WriteLine(ArabaDurumu(15));
        Console.WriteLine(ArabaDurumu(25));

        // 3. Ödev: While ve Do-While Döngüleri
        WhileVeDoWhileOrnekleri();

        // 4. Ödev: Çalışanların Maaş Hesaplaması
        MaasHesaplama();

        // 5. Ödev: Arabaların Benzin Tüketimi
        BenzinTuketimiHesapla();
    }

    // 1. Ödev
    static string YasKategoriBelirle(int yas)
    {
        if (yas < 0 || yas > 99) return "Ya hiç doğmadınız ya da çoktan öldünüz...";
        if (yas < 18) return "Küçüksünüz";
        if (yas < 35) return "Gençsiniz";
        if (yas < 55) return "Yetişkinsiniz";
        if (yas < 75) return "Yaşlısınız";
        return "Çok yaşlısınız";
    }

    // 2. Ödev
    static string ArabaDurumu(int yas)
    {
        if (yas < 0 || yas > 30) return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        if (yas < 10) return "Arabanız yeni";
        if (yas < 20) return "Servise götürmeniz gerekebilir";
        return "Arabanız hurdaya çıkabilir";
    }

    // 3. Ödev: While ve Do-While Döngüleri
    static void WhileVeDoWhileOrnekleri()
    {
        int i = 5;
        Console.WriteLine("While döngüsü:");
        while (i > 0)
        {
            Console.WriteLine(i);
            i--;
        }

        i = 5;
        Console.WriteLine("Do-While döngüsü:");
        do
        {
            Console.WriteLine(i);
            i--;
        } while (i > 0);
    }

    // 4. Ödev: Çalışanların Maaş Hesaplaması
    class Calisan
    {
        public required string Ad { get; set; }
        public required string Soyad { get; set; }
        public required string Meslek { get; set; }
        public int Maas { get; set; }
        public required string Departman { get; set; }
    }
    static void MaasHesaplama()
    {
        List<Calisan> calisanlar = new List<Calisan>
        {
            new Calisan { Ad = "Ali", Soyad = "Yılmaz", Meslek = "Genel Müdür", Maas = 30000, Departman = "Yönetim" },
            new Calisan { Ad = "Ayşe", Soyad = "Demir", Meslek = "Müdür", Maas = 20000, Departman = "Satış" },
            new Calisan { Ad = "Mehmet", Soyad = "Kaya", Meslek = "Programcı", Maas = 15000, Departman = "IT" },
            new Calisan { Ad = "Zeynep", Soyad = "Çelik", Meslek = "Stajyer", Maas = 5000, Departman = "IT" }
        };

        int toplamMaas = 0;
        foreach (var calisan in calisanlar)
        {
            Console.WriteLine($"{calisan.Ad} {calisan.Soyad} - {calisan.Meslek} - {calisan.Maas} TL - {calisan.Departman}");
            toplamMaas += calisan.Maas;
        }

        Console.WriteLine("Toplam Maaş: " + toplamMaas + " TL");
    }

    // 5. Ödev: Arabaların Benzin Tüketimi
    class Araba
    {
        public required string Marka { get; set; }
        public required string Model { get; set; }
        public int Yil { get; set; }
        public double Tuketim { get; set; } // L/100km
    }
    static void BenzinTuketimiHesapla()
    {
        List<Araba> arabalar = new List<Araba>
        {
            new Araba { Marka = "Toyota", Model = "Corolla", Yil = 2020, Tuketim = 6.5 },
            new Araba { Marka = "BMW", Model = "3 Serisi", Yil = 2018, Tuketim = 8.0 },
            new Araba { Marka = "Ford", Model = "Focus", Yil = 2015, Tuketim = 7.2 }
        };

        double toplamTuketim = 0;
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"{araba.Marka} {araba.Model} - {araba.Yil} - {araba.Tuketim} L/100km");
            toplamTuketim += araba.Tuketim;
        }

        Console.WriteLine("Toplam Benzin Tüketimi: " + toplamTuketim + " L/100km");
    }
}

