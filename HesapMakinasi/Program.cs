using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Hesap Makinasına Hoşgeldiniz! | developed by Mors ");
            Console.WriteLine(new string('-', 60));

            System.Threading.Thread.Sleep(250);

            int islem;
            double sayi1, sayi2;

            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin; Toplama(1),Çıkarma(2),Çarpma(3),Bölme(4)");
            islem = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nBir sayı değeri girin --> ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci bir sayı değeri girin --> ");
            sayi2 = Convert.ToDouble(Console.ReadLine());



            switch (islem)

            {
                case 1:
                    Console.WriteLine($"Girilen Değerler => {sayi1} + {sayi2} \n\n**Sonuç => {sayi1 + sayi2}**");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("Kullanımınız İçin Teşekkürler!");

                    break;
                case 2:
                    Console.WriteLine($"Girilen Değerler => {sayi1} - {sayi2} \n\n**Sonuç => {sayi1 - sayi2}**");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("Kullanımınız İçin Teşekkürler!");
                    break;

                case 3:
                    Console.WriteLine($"Girilen Değerler => {sayi1} x {sayi2} \n\n**Sonuç => {sayi1 * sayi2}**");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("Kullanımınız İçin Teşekkürler!");
                    break;

                case 4:
                    Console.WriteLine($"Girilen Değerler => {sayi1} / {sayi2} \n\n**Sonuç => {sayi1 / sayi2}**");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("Kullanımınız İçin Teşekkürler!");
                    break;

                default:
                    Console.WriteLine("\nİşlem Değeri En Fazla '4' Olmalıdır.\n\nHatalı bir tuşlama yapıldı.\n\nÇıkış Yapılıyor.");
                    break;

            }
            Console.Read();
        }
    }
}
