using System;

namespace RecursiveAndExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz yinelemeli Fonksiyon
            //örneğin sayının üssünü alma işlemi 
            //3^4 = 3*3*3*3
            int result = 1;
            for (int i = 0; i < 4; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar 
            string ifade = "Melek Doğan";
            bool sonuc = ifade.checkSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.SortArray();
            dizi.EkranaYazdir();
            int sayi = 5;
            Console.WriteLine( sayi.IsEvenNumber() );
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us<2)
            {
                return sayi;

            }
            return Expo(sayi, us - 1) * sayi;
        }
        //Expo(3,4)
        //Expo(3,3)*3;
        //Expo(3,2)*3*3;
        //Expo(3-1)*3*3*3;
        //3*3*3*3=3^4

        
    }
    static class Extension
    {
        public static bool checkSpaces(this string param)
        {
           return  param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(' ');
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
       public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.Write(item+" ");
            }
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
