using System;

namespace data_types_00
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tip donusumleri");
			byte a = 5;
			sbyte b = 30;
			short c = 10;
			
			int d = a+b+c;
			Console.WriteLine("d:" + d);
			
			// *** ToString Methodu ***
			Console.WriteLine("***ToStringMethodu***");
			int xx = 6;
			string yy = xx.ToString();
			Console.WriteLine("yy:" +yy);
			
		}
	}
}





// Notepad ++ kullanıyorum.
// Welcome to Data Types
int i = 4;
double dd = 4.0;
string s ="HackerRank";
// Declare second integer, double and String variables.
int i1;
double dd1;
string s1;
// Read and save an integer, double, String to your variables.
i1 = int.Parse(Console.ReadLine());
dd1 = double.Parse(Console.ReadLine());
s1 = Console.ReadLine();
// int i1 = 10;
// double dd1 = 4,2;
// string s1 ="is the best place to learn and practise coding!";


// docs.microsoft.com 
int aa1 = 123;
long bb1 = aa1;        // implicit conversion from int to long
int cc1 = (int) bb1;   // explicit conversion from long to int