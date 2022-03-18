using System;

namespace over_loading
{
	class Program
	{
		static void Main(string[] args)
		{
            // out parametreler
			string sayi ="999";
			int outSayi;
			
			bool sonuc = int.TryParse(sayi, out int OutSayi);
			if(sonuc)
			{
				Console.WriteLine("Başarılı!");
				Console.WriteLine(outSayi);
			}
			else
			{
				Console.WriteLine("Başarısız");
			}			
		}