using System;

namespace hata_yonetimi
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş oldugunuz sayi :") + sayi;
			}
			catch(Exception ex)
			{
				Console.WriteLine("Hata: "+ ex.Message.ToString());
			}
			//finally
			// {
			//	Console.Write("İşlem tamamlandi.");				
			// }
			try
			{
				int a = int.Parse(mull);
			}
			catch(ArgumentNullException ex)
			{
				Console.WriteLine("Bos deger girdiniz.");
				Console.WriteLine(ex);
				// Value cannot be null.
			}
			finally
			{
				Console.WriteLine("İslem basariyla tamamlandi.");
			}
			
		}
	}
}

// FormatException
// Veri tipi uygun degil.

// OverflowException
// Cok kucuk yada cok buyuk deger girildi.









