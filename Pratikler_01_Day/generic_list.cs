using System;
using System.Collections.Generic;

namespace generic_list
{
	class Program
	{
		static void Main(string[] args)
		{
			// List<T> class
			// System.Collections.Generic
			// T-> object türündendir
			
			List<int> sayiListesi = new List<int>();
			
			sayiListesi.Add(23);
			sayiListesi.Add(10);
			sayiListesi.Add(4);
			sayiListesi.Add(5);
			sayiListesi.Add(92);
			sayiListesi.Add(34);
			
			List<string> renkListesi = new List<string>();
			renkListesi.Add("Kırmızı");
			renkListesi.Add("Mavi");
			renkListesi.Add("Turuncu");
			renkListesi.Add("Sarı");
			
			// Count
			Console.WriteLine(renkListesi.Count);
			Console.WriteLine(sayiListesi.Count);
			
			// Foreach ve List.ForEach ile elemanlara erişim
			sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
			
			// Listeden elemean çıkarma
			sayiListesi.Remove(4);
			renkListesi.Remove("Kırmızı");
			sayiListesi.RemoveAt(0);
			renkListesi.RemoveAt(1); // verdiğimiz indexteki veriyi siliyor
			
			// Liste içerisinde  arama
			if(sayiListesi.Contains(10))
				Console.WriteLine("10 Liste içerisinde bulundu");
			
			// Diziyi liste çevirmek
			string[] hayvanlar = {"Kedi","Köpek","Tavsan"};
			List<string> hayvanListesi = new List<string>(hayvanlar);
			
			// Listeyi nasıl temizleriz ?
			hayvanListesi.Clear();
			
			// List içerisinde nesne tutmak
			List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
			
			Kullanıcılar kullanıcı1 = new Kullanıcılar();
			kullanıcı1.Isim ="Ayse";
			kullanıcı1.Soyİsim ="Yilaz"; 
			kullanıcı1.Yas =20;
			
			Kullanıcılar kullanıcı2 = new Kullanıcılar();
			kullanıcı2.Isim ="Tugce";
			kullanıcı2.Soyİsim ="Tosun"; 
			kullanıcı2.Yas =22;
			
			kullanıcıListesi.Add(kullanıcı1);
			kullanıcıListesi.Add(kullanıcı2);
			
			List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
			
			yeniListe.Add = new Kullanıcılar(){
			  Isim ="Ayse",
			  Soyİsim ="Durmus",
			  Yas =60;
			});
			
			foreach(var kullanıcı in kullanıcıListesi)
			{
				Console.WriteLine("Kullanici Adi: "+ kullanıcı.Isim);
				Console.WriteLine("Kullanici Soyadi: "+ kullanıcı.Soyİsim;
				Console.WriteLine("Kullanici Yas: "+ kullanıcı.Yas);
				
			}
			
		}
	}
	public class Kullanıcılar{
		private string isim;
		private string soyisim;
		private int yas;
		
		public string Isim { get => isim; set => isim = value; }
		public string Soyisim { get => soyisim; set => soyisim = value;}
		public int Yas { get => yas; set => yas = value;}
	}
}