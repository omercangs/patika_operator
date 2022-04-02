using System;
using System.Collections;
using System.Collections.Generic;

namespace dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			// system.collection.generic
			Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
			
			kullanıcılar.Add(10,"Tugce");
			kullanıcılar.Add(12,"Omer");
			kullanıcılar.Add(18,"Can");
			kullanıcılar.Add(20,"Durmus");
			
			// dizinin elemanlarına erisim
			Console.WriteLine("****Elemanlara Erisim****");
			Console.WriteLine(kullanıcılar[12]);
			foreach(var item in kullanıcılar)
			  Console.WriteLine(item);
			
			// Count
			Console.WriteLine("****Count****");
			Console.WriteLine(kullanıcılar.Count);
			
			// Contains
			Console.WriteLine("****Contains****");
			Console.WriteLine(kullanıcılar.ContainsKey(12));
			Console.WriteLine(kullanıcılar.ContainsValue("Tugce"));
			
			// Remove
			Console.WriteLine("****Remove****");
			kullanıcılar.Remove(12);
			foreach(var item in kullanıcılar)
			  Console.WriteLine(item.Value);
			  
			// Keys
			// Values
			// patika-dev
			
		}
	}
}