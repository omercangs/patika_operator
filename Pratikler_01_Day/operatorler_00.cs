using System;
// Day 0 Hello World
// Console.WriteLine("Hello World");
namespace operatorler
{
	class Program
	{
		static void Main(string[] args)
		{
			// Atama ve islemli atama
			int x = 3;
			int y = 3;
			y = y+2;
			
			Console.WriteLine(y);
			y += 2;
			Console.WriteLine(y);
			
			//Mantıksal Operatorler
			bool isSuccess = true;
			bool isCompleted = true;
			if(isSuccess && isCompleted)
			   Console.WriteLine("Perfect!");
		}
		
	}
	
}
