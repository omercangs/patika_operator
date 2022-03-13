using System;

namespace donguler_01
{
	class Program
	{
		static void Main(string[] args)
		{
			// While
			// 1 den baslayarak consoledan girilen sayıya kadar (sayi dahil) ortalama hesaplayıp console a yazdiran program
			Console.Write("Lütfen bir sayi giriniz: ");
			int sayi = int.Parse(Console.ReadLine());
			int sayac = 1;
			while(sayac<=sayi)
			{
				toplam += sayac;
				sayac++;
			}
			Console.WriteLine(toplam/sayi);
			
		}
	}
}

//
//int sayac = 1;
//while (sayac <= 5)
//{
//Console.WriteLine(sayac);
//sayac++;
//}
//sayac başlangıçta 1 olarak verilmiş
//sayaç 5 den küçük veya 5'e eşit olduğu sürece console'a sayacın değerini yazdıracak
//her döngü sonunda sayacın değerini bir arttıracak.
// Notepad++

//foreach ex
//int[] sayiDizisi = {2,4,5,1,2,4};
//int toplam = 0 ;

//foreach(int i in SayiDizisi)
//{
//toplam += i ;
//}