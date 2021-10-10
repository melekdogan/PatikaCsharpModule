using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Girmiş olduğunuz sayı: {sayi}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
                
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
          */


            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("test");
                int b = int.Parse("2939939283928");    
            }
            catch (ArgumentNullException ex )
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine($"Hata: {ex}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil!");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı.");
            }
            Console.ReadKey();

        }
    }
}
