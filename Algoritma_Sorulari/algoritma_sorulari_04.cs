using System;

namespace algoritma_sorulari_04
{
	class Program
	{
		static void Main(string[] args)
		{
			// Ekrana bir cümle yazdır
			string cumle;
			Console.Write("Lütfen bir cümle giriniz  : ");
			cumle = Console.ReadLine();
			string[] kelimeler = cumle.Split(' ');
			Console.WriteLine("Kelime sayisi :"+kelimeler.Length);
			foreach(string kelime in kelimeler)
			{
				Console.WriteLine(kelime);
			}
			Console.ReadKey();
		}
	}
}
// www.patika.dev