using System;

namespace static_sinif_01

{
	class Program
	{
		static void Main(string[] args)
		{
			// patika.dev
			
			Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
			
			Calisan calisan = new Calisan("Ayse","Yilmaz","IK");
			Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
			Calisan calisan1 = new Calisan("Mahmut","Yilmaz","IK");
			Calisan calisan2 = new Calisan("Zeynep","Yilmaz","IK");
			
			Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
			
			Console.WriteLine("Toplama islemi sonucu: {0} ", Islemler.Topla(100,200));
			Console.WriteLine("Cikarma islemi sonucu: {0} ", Islemler.Cikar(400,50));
		
			
		}
	}
	
	class Calisan
	{
		private static int calisanSayisi;
		
		public static int CalisanSayisi { get => calisanSayisi;}
		
		private string Isim;
		
		private string Soyisim;
		
		private string Departman;
		
		static Calisan(){
			calisanSayisi = 0;
		}
		
		public Calisan(string isim, string soyisim, string departman)
		{
			this.Isim = isim;
			this.Soyisim = soyisim;
			this.Departman = departman;
			calisanSayisi ++;
		}
		
	}
	
	static class Islemler
	{
		public static long Topla(int sayi1, int sayi2)
		{
			return sayi1+sayi2;
		}
		public static long Cikar(int sayi1, int sayi2)
		{
			return sayi1-sayi2;
		}
	}
}