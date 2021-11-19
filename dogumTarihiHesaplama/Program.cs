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
            Console.Write
                (@"           ^_^
   |m|_   (· ·)
   \ /    _| |_                      _____________________________
   |_|___/   _ \                    |  ____           __    __    |
   |____,     | \                   | /  __|       __/  /__/  /__ |                    
        |     / /                   ||  /         /__  .__   .__/ |
        |_____\/                    ||  \__        /__/  /__/     |
        |¯¯¯¯¯|                     | \____|                      |
        |  |  |                     |                             |
        |  |  |                     |_____________________________|
        |  |  |
        |  |  |
        |  |  |
      __/--||--\__
     |_____)(_____|
---------------------
");

            
        }
    }

}