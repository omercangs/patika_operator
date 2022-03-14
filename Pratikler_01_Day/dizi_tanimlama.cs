// dallari ve donguleri birlestirme
int tekToplam = 0;
for(int i = 1; i < 20; i++)
{
    if(i % 3 ==0)
    {
        tekToplam += i;
        Console.WriteLine("TekToplam: " + tekToplam);
    }
}

// dogrusu
int sum = 0;
for (int number = 1; number < 21; number++)
{
  if (number % 3 == 0)
  {
    sum = sum + number;
  }
}
Console.WriteLine($"The sum is {sum}");

// counter, sayac

int counter = 0;
while (counter <= 5)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
}

//
var name = "Ana";
Console.WriteLine($"Hello {name}!");

var name = "Ana";
Console.WriteLine($"Hello {name.ToUpper()}!");

// dongulerde dizi kullanımı
int[] sayiDizisi = new int[20];
int toplam = 0;
for (int i = 0; i < sayiDizisi.Length; i++)
  {
    Console.Write("Lütfen {0}. sayıyı girin:", i+1);
    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
    toplam += sayiDizisi[i];
  }
double ortalama = toplam / 20;
Console.WriteLine("Sayıların ortalaması: " + ortalama);
Console.ReadLine();