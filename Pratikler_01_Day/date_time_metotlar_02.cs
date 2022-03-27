using System;

namespace date_time_metotlar_02
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);	
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
			
			// Math Kütüphanesi
			Console.WriteLine(Math.Abs(-25)); // 25 Mutlak Deger
			Console.WriteLine(Math.Sin(10));
			Console.WriteLine(Math.Cos(10));
			Console.WriteLine(Math.Tan(10));
			
			Console.WriteLine(Math.Ceiling(22.3));   // 23
			Console.WriteLine(Math.Round(22.3));    // 22
			Console.WriteLine(Math.Round(22.7));   // 23
			Console.WriteLine(Math.Floor(22.7));  //22
			
			Console.WriteLine(Math.Min(2,6));
			Console.WriteLine(Math.Max(2,6));
			
			Console.WriteLine(Math.Pow(3,4));  //üs verir output: 81
			Console.WriteLine(Math.Sqrt(9));   // karekök alır
		}
	}
}