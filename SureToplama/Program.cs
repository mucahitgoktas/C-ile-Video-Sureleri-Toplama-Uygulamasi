using System;

namespace ConsoleApp1
{

    class Program
    {
        struct zaman
        {
            public int saat, dakika, saniye;

        }
        static void Main(string[] args)
        {

            int toplamsaat = 0;
            int toplamdakika = 0;
            int toplamsaniye = 0;
            int saatSonuc = 0;
            int dakikaSonuc = 0;
            int saniyeSonuc = 0;


            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("***VIDEO SURELERI HESAPLAMA PROGRAMI***");
                Console.Write("Saat :");
                int saat = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dakika :");
                int dakika = Convert.ToInt32(Console.ReadLine()); 
                Console.Write("Saniye :");
                int saniye = Convert.ToInt32(Console.ReadLine()); 
                toplamsaat = saat + toplamsaat;
                toplamdakika = toplamdakika + dakika;
                toplamsaniye = toplamsaniye + saniye;
                var dakika1 = Dakikahesapla(toplamdakika);
                var saniye1 = Saniyehesapla(toplamsaniye);
                saatSonuc = dakika1.saat + toplamsaat;
                dakikaSonuc = dakika1.dakika + saniye1.dakika;
                saniyeSonuc = saniye1.saniye;









            }

            Console.WriteLine("\n----------*S*O*N*U*Ç*----------");
            Console.WriteLine("   {0} Saat {1} Dakika {2} Saniyedir.", saatSonuc, dakikaSonuc, saniyeSonuc);
            Console.ReadLine();

        }

        private static zaman Saniyehesapla(int saniye)
        {
            var zaman = new zaman();
            if (saniye >= 60)
            {
                int dakikaeki = saniye / 60;
                saniye %= 60;
                zaman.dakika = zaman.dakika + dakikaeki;
                zaman.saniye = saniye;


            }
            else
            {
                zaman.dakika = 0;
            }


            return zaman;

        }

        private static zaman Dakikahesapla(int dakika)
        {
            var zaman = new zaman();
            if (dakika >= 60)
            {


                int saateki = dakika / 60;
                dakika %= 60;
                zaman.saat = zaman.saat + saateki;
                zaman.dakika = dakika;



            }
            else
            {
                zaman.saat = 0;
            }



            return zaman;



        }

    }
}
