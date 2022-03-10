using System;

namespace if_else
{
	class Program
	{
		static void Main(string[] args)
		{
			int time = DateTime.Now.Hour;
			// O anki saati alabiliyoruz.
			if(time>=6 && time<11)
			  Console.WriteLine("Günaydın");
			else if(time<= 18)
			  Console.WriteLine("İyi günler!");
			else
			  Console.WriteLine("İyi aksamlar");
		}
	}
}


// bir diger ornek

//bool condition = true;

//if (condition)
//
//  Console.WriteLine("Değişken: true");
//
//else

//Console.WriteLine("Değişken: false");


//Console.WriteLine("Bir sayı giriniz: ");
// Cift olup olmadigina 2 ye gore modunu alarak ogreniyoz
// if(n % 2 == 1)
// || veya demek