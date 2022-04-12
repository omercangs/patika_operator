using System;

namespace kurucu_metotlar
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
			Console.WriteLine("******Çalışan 1*******");
			Calisan calisan1 = new Calisan("Murat","Demirbas",256256,"İnsan Kaynaklari");
			calisan1.CalisanBilgileri();
			
			Console.WriteLine("******Çalışan 2*******");
			Calisan calisan2 = new Calisan();
			calisan2.Ad = "Berat";
			calisan2.Soyad = "Demirbas";
			calisan2.No = 123123;
			calisan2.Departman = "Satin Alma";
			
			calisan2.CalisanBilgileri();
			Console.WriteLine("******Çalışan 3*******");
			Calisan.calisan3 = new Calisan("Zikriye","Urkmez");
			calisan3.CalisanBilgileri();
			
		}
	}
	
	class Calisan
	{
		public string Ad;
		
		public string Soyad;
		
		public int No;
		
		public string Departman;
		
		public Calisan(string ad, string soyad, int no, string departman)
		{
			this.Ad = ad;
			this.Soyad = soyad;
			this.No = no;
			this.Departman = departman;
		}
		
		public Calisan(){}
		
		public void CalisanBilgileri()
		{
			Console.WriteLine("Çalışanın Adı:{0}", Ad);
			Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
			Console.WriteLine("Çalışanın Numarası:{0}", No);
			Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
		}
	}
}