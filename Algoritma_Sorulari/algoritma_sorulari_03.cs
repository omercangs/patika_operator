using System;

namespace algoritma_sorulari_03
{
	class Program
	{
		static void Main(string[] args)
		{
			// Kullanıcan pozitif bir sayı iste
			// n adet kelime gir
			Console.Write("Bir pozitif sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Bir kelime giriniz: ");
                array[i] = Convert.ToString(Console.ReadLine());
            }
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
            // Reverse
            Array.Reverse(array);
            foreach(var i in array)
            {
                Console.WriteLine(i);
            }
		}
	}
}
// www.patika.dev