using System;

namespace donguler
{
	class Program
	{
		static void Main(string[] args)
		{
			// Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
			Console.Write("Lütfen bir sayı giriniz: ");
			int sayac = int.Parse(Console.ReadLine());
			for(int i =1; i<= sayac; i++)
			{
				if(i%2 == 1)
				{
					Console.WriteLine(i);
				}
			}
			
			// 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
			int tekToplam = 0;
			int çiftToplam = 0;
			for(int i=1; i<=1000; i++)
			{
				if(i%2 ==1)
				   tekToplam += i; // Tek Toplam = Tek Toplam + i;
				else
				   çiftToplam += i; // Çift Toplam = Çift Toplam + i;
			}
			
			Console.WriteLine("TekToplam: "+ tekToplam);
			Console.WriteLine("ÇiftToplam: "+ çiftToplam);
		}
	}
}


// Notlar
for(;;) // Sonsuz döngüyü ifade eder. 

// Örnek bir for döngüsü 2 ifade, 1 koşuldan oluşur.

for(ifade1;kosul;ifade2)
{
    komut1;
    komut2;
}

//ifade1: Döngünün sayacının tanımlandığı ve atamasının yapıldığı ifadedir. Örneğin; int i=0;

//ifade2: Döngünün sayacının artırım yada azaltım şeklini belirten ifadedir. Örneğin ; i++, i-- gibi.

//koşul: döngünün devam etme koşuludur. Bu koşul sağlandığı sürece döngü devam eder. Örneğin : i<=12;





















// .Net Editor