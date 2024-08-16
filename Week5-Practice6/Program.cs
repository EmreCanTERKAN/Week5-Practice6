using System;
using Week5_Practice6;


class Program
{

    static public void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();

        while (true)
        {
            Console.WriteLine("Araba üretmek istiyor musunuz? (e/h): ");
            string cevap = Console.ReadLine().ToLower();

            if (cevap == "h")
            {
                Console.WriteLine("Program sonlandırıldı.");
                break;
            }
            else if (cevap == "e")
            {
                Araba yeniAraba = new Araba();

                Console.Write("Seri Numarası: ");
                yeniAraba.SeriNumarasi = Console.ReadLine();

                Console.Write("Marka: ");
                yeniAraba.Marka = Console.ReadLine();

                Console.Write("Model: ");
                yeniAraba.Model = Console.ReadLine();

                Console.Write("Renk: ");
                yeniAraba.Renk = Console.ReadLine();

            KapıSayisiYeniden:
                try
                {
                    Console.Write("Kapı Sayısı: ");
                    yeniAraba.KapiSayisi = int.Parse(Console.ReadLine());
                    if (!(yeniAraba.KapiSayisi == 2 || yeniAraba.KapiSayisi == 4))
                    {
                        Console.WriteLine("2 ve 4 değeri gir.");
                        goto KapıSayisiYeniden;
                    }
                    
                }
                
                
                catch (FormatException)
                {
                    
                       Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer giriniz.");
                    goto KapıSayisiYeniden;
                }
                

                arabalar.Add(yeniAraba);

                Console.WriteLine("\nYeni Araba Bilgileri:");
                Console.WriteLine($"Üretim Tarihi: {yeniAraba.UretimTarihi}");
                Console.WriteLine($"Seri Numarası: {yeniAraba.SeriNumarasi}");
                Console.WriteLine($"Marka: {yeniAraba.Marka}");
                Console.WriteLine($"Model: {yeniAraba.Model}");
                Console.WriteLine($"Renk: {yeniAraba.Renk}");
                Console.WriteLine($"Kapı Sayısı: {yeniAraba.KapiSayisi}");
            }
            else
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'e' ya da 'h' giriniz.");
            }

            // Kullanıcıya başka araba üretmek isteyip istemediğini soralım
            Console.WriteLine("\nBaşka bir araba üretmek ister misiniz? (e/h): ");
            string devamCevap = Console.ReadLine().ToLower();

            if (devamCevap == "h") 
            {
                bitis:
                Console.WriteLine("\nTüm Arabalar:");
                foreach (var araba in arabalar)
                {
                    Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
                }
                break;
            }
            else if (devamCevap != "e")
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'e' ya da 'h' giriniz.");
            }
        }

    }




}