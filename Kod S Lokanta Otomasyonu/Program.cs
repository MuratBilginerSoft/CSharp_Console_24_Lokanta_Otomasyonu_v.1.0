using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Lokanta_Otomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************Industryolog Akademi********************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Giriş İçin Bir Tuşa Basınız");
            Console.ReadKey();

            double adet, secim, i, secim2, toplam, toplam2 = 0;
            Console.WriteLine("**************************************************************");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("*       YİYECEKLER            **         İÇECEKLER           *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 1-   Kuru fasulye: 3.00 TL  ** 8-    Kola:    2.00 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 2-   Çiğ köfte: 3.00 TL     ** 9-    Ayran:   1.00 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 3-   Çorba:    2.00 TL      ** 10-   Fanta:   2.00 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 4-   Döner:    2.50 TL      ** 11-   Çamlıca: 1.00 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 5-   Pilav:    2.50 TL      ** 12-   Su:      0.75 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 6-   Makarna:  3.50 TL      ** 13-   Çay:     1.50 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 7-   işkembe:  2.00 TL      ** 14-   Cappy:   2.00 TL      *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("");

            secim = 100;

            for (i = 1; i <= secim; i++)
            {
                Console.WriteLine(" ");
                Console.Write("Alacağınız Ürün Numarası:");
                secim2 = Convert.ToDouble(Console.ReadLine());

                if (secim2 == 1)
                {
                    Console.Write("Kaç Adet Kuru Fasulye İstiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 3 * adet;
                    toplam2 += toplam;

                }
                else if (secim2 == 2)
                {
                    Console.Write("Kaç Adet çiğ köfte istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 3 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 3)
                {
                    Console.Write("Kaç Adet çorba istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 2 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 4)
                {
                    Console.Write("Kaç Adet döner istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 2.5 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 5)
                {
                    Console.Write("Kaç Adet pilav istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 2.5 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 6)
                {
                    Console.Write("Kaç Adet makarna istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 3.5 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 7)
                {
                    Console.Write("Kaç Adet işkembe istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 2 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 8)
                {
                    Console.Write("Kaç Adet kola istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 2 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 9)
                {
                    Console.Write("Kaç Adet ayran istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 1 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 10)
                {
                    Console.Write("Kaç Adet fanta istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 2 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 11)
                {
                    Console.Write("Kaç Adet çamlıca istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 1 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 12)
                {
                    Console.Write("Kaç Adet su istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 0.75 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 13)
                {
                    Console.Write("Kaç Adet çay istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 1.5 * adet;
                    toplam2 += toplam;
                }
                else if (secim2 == 14)
                {
                    Console.Write("Kaç Adet cappy istiyorsunuz:");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = 2 * adet;
                    toplam2 += toplam;
                }
                else
                    Console.WriteLine("Menüde böyle bir seçim yok ");
                Console.WriteLine("");
                Console.Write("başka isteğiniz var mı? (E/H) ");
                string cev = Console.ReadLine();
                if ((cev == "h") || (cev == "H") || (cev == "hayır") || (cev == "HAYIR"))
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Toplam Tutar:{0:C}", toplam2);

            Console.ReadKey();

        }
    }
}
