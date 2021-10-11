using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Söz Dizimi
             * Class SinifAdi
             * {
             * [Erişim Belirleyici] [veri tipi] OzellikAdi;
             * [Erişim Belirleyici] [geri dönüş tipi] MetotAdi([Parametre Listesi])
             * {
             * metot komutları
             * }
             * 
             * 
             * ------ Erişim Belirleyiciler -------
             * * Public: Her yerden erişilebilir.
             * * Private: Sadece tanımlandığı sınıf içerisinden erişilebilir
             * * Internal: Sadece tanımlandığı proje içerisinden erişilebilir.
             * * Protected: Sadece tanımlandığı sınıf ve bu sınıftan miras alan diğer sınıflardan erişilebilir. 
             */

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 1232323;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            Console.WriteLine("*****************************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 129382389;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı: {Ad}");
            Console.WriteLine($"Çalışan Soyadı: {Soyad}");
            Console.WriteLine($"Çalışan Numarası: {No}");
            Console.WriteLine($"Çalışan Departmanı: {Departman}");
        }
    }
}
