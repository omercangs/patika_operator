using System;

namespace karar-yapilari_00
{
	class Program
	{
		static void Main(string[] args)
		{
			int month = DateTime.Now.Mouth;
			
			// Expression
			switch (month)
			{
				case 1:
				  Console.WriteLine("Ocak ayindasiniz");
				  break;
				case 2:
				  Console.WriteLine("Subat ayindasiniz!");
				  break;
				case 3 :
				  Console.WriteLine("Mart ayindasiniz");
				default:
				  Console.WriteLine("Yanlis veri girisi");
				break;
			}
		}
	}
}

//karar-yapilari
int age;
if(age < 13)
  Console.WriteLine("You are young");
if(age >=13 && age < 18)
  Console.WriteLine("You are teenager");
  
//Örnek bir switch-case ifadesi :

switch(degisken)
{
    case sabit1:
        komutlar;
        break;
    case sabit2:
        komutlar;
        break;
    case sabit3:
        komutlar;
        break;
    default:
        komutlar;
        break;
}

switch (month)
{
	case 12:
	case 1:
	case 2:
		Console.WriteLine("Kis ayindasiniz");
	break;
}