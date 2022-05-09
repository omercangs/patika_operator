using System;

namespace struct_yapi

{
	class Program
	{
		static void Main(string[] args)
		{
			// patika.dev
			Dikdortgen dikdortgen = new Dikdortgen();
			dikdortgen.KısaKenar = 3;
			dikdortgen.UzunKenar = 4;
			
			Console.WriteLine("Class Alan Hesabı  :{0}", dikdortgen.AlanHesapla());
			
			Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct(3,4);		
			Console.WriteLine("Class Alan Hesabı  :{0}", dikdortgen_struct.AlanHesapla());
			
			
			
		}
	}
	
	class Dikdortgen
	{
		public int KısaKenar;
		
		public int UzunKenar;
		
		public long AlanHesapla()
		{
			return this.KısaKenar * this.UzunKenar;
		}

		
	}
	
	struct Dikdortgen_Struct
	{
		public int KısaKenar;
		
		public int UzunKenar;
		
		public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
		{
			KısaKenar = kisaKenar; 
			UzunKenar = uzunKenar;
		}
		
		public long AlanHesapla()
		{
			return this.KısaKenar * this.UzunKenar;
		}
	}
}