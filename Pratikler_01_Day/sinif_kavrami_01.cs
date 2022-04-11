using System;

namespace sinif_kavrami_01
{
	class Program
	{
		static void Main(string[] args)
		{
			// patika.dev
			// Söz Dizimi
			// class SinifAdi
			// {
			// [Erisim Belirleyici][ veri tipi ] OzellikAdi;
			// [Erisim Belirleyici][ geri donus tipi ] MetotAdi([Parametre Listesi]);
			// }
			// {
			// Metot Komutlari
			// }
			
			Calisan calisan1 = new Calisan();
			calisan1.Ad = "Murat";
			calisan1.Soyad = "Demirbas";
			calisan1.No = 256256;
			calisan1.Departman = "İnsan Kaynaklari";
			calisan1.CalisanBilgileri();
			Console.WriteLine("*************");
			
			Calisan calisan2 = new Calisan();
			calisan2.Ad = "Berat";
			calisan2.Soyad = "Demirbas";
			calisan2.No = 123123;
			calisan2.Departman = "Satin Alma";
			
			calisan2.CalisanBilgileri();
			
		}
	}
	
	class Calisan
	{
		public string Ad;
		
		public string Soyad;
		
		public int No;
		
		public string Departman;
		
		public void CalisanBilgileri()
		{
			Console.WriteLine("Çalışanın Adı:{0}", Ad);
			Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
			Console.WriteLine("Çalışanın Numarası:{0}", No);
			Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
		}
	}
}