using System;

namespace hazir_metotlar_string
{
	class Program
	{
		static void Main(string[] args)
		{
			string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            // Length
			Console.WriteLine(degisken.Length);
			// Concat
			Console.WriteLine(String.Concat(degisken," Merhaba!");
			// Concat birlestiriyor
			// Output : Dersimiz CSharp, Hoşgeldiniz! Merhaba!
			
			// Remove
			//Onuncu indexten baslayip sonuna kadar siliyor
			Console.WriteLine(degisken.Remove(10));
			
			// Substring
			// Dördünce indexten sonrasini getiriyor
			Console.WriteLine(degisken.Substring(4));
			
			// Replace
			Console.WriteLine(degisken.Replace("CSharp","C#"));
		}
	}
}