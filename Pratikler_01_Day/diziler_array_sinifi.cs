using System;

namespace diziler_array_sinifi
{
	class Program
	{
		static void Main(string[] args)
		{
			// Sort
			int[] sayiDizisi = {23,12,4,86,72,3};
			
			Console.WriteLine("****Sırasız Dizi****");
			foreach(var sayi in sayiDizisi)
			Console.WriteLine(sayi);
			
			Console.WriteLine("****Sırali Dizi****");
			Array.Sort(sayiDizisi);
			foreach(var sayi in sayiDizisi)
			Console.WriteLine(sayi);
			
			// Clear
			Console.WriteLine("****Array Clear****");
			// sayi Dizisi elemanlarını kullanarak 2.indexten baslayarak 2 tane elemanı sıfırlar
			Array.Clear(sayiDizisi);
		}
	}
}