using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Özyılmaz";
            ogrenci.OgrenciNo = 454;
            ogrenci.Sinif = 3;

            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
           
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif {
            get { 
                return sinif; 
            }
            set {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.ogrenciNo = ogrenciNo;
            this.sinif = sinif;
        }
        public Ogrenci() { }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*********** Ogrenci Bilgileri *********");
            Console.WriteLine($"Öğrenci adı: {this.isim}");
            Console.WriteLine($"Öğrenci soyadı: {this.soyisim}");
            Console.WriteLine($"Öğrenci numarası: {this.ogrenciNo}");
            Console.WriteLine($"Öğrenci sınıfı: {this.sinif}");
        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif+1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif-1;
        }

    }
}
