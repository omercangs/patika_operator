using System;

namespace algoritma_sorulari_01
{
	class Program
	{
		static void Main(string[] args)
		{
			// Ekrandan girilen sayıya kadar olan çift sayıları ekrana yazdır
			Console.Write("Lütfen bir sayı giriniz: ");
			int sayac = int.Parse(Console.ReadLine());
			for(int n =1; n<= sayac; n++)
			{
				if(n%2 == 0)
				{
					Console.WriteLine(n);
				}
			}
		}
	}
}
// www.patika.dev