using System;

namespace dogumTarihiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = DateTime.Now;
            Console.WriteLine("Doğum Yılınızı Giriniz");
            int yıl = tarih.Year;
            int dogumtarihi = Convert.ToInt32(Console.ReadLine());

            int sonuc = yıl - dogumtarihi;

            Console.WriteLine("Yaşınız : " + sonuc);

        }
    }
}
