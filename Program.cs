using System;
namespace hatayonetimi{
    class Program{
        static void Main(string[] args){
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı=" + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message);
                throw;
            }
         
        finally
        {
            Console.WriteLine("İşlem tamamlandı.");

        }
            try {
                int a=int.Parse(null);
                }
            catch(ArgumentException ex){
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
        {
            Console.WriteLine("İşlem tamamlandı.");

        }
        try {
            int b=int.Parse("test");
        }
        catch(FormatException ex){
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);

        }
         finally
        {
            Console.WriteLine("İşlem tamamlandı.");

        }
         try{
            int c=int.Parse("-20000000000");
         }   
         catch(OverflowException ex){
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
    }
        finally
        {
            Console.WriteLine("İşlem başarıyla tamamlandı.");

        }
        }}}