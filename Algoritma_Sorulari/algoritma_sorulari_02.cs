using System;

namespace algoritma_sorulari_02
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Lütfen pozitif bir sayı giriniz: ")
			int n = int.Parse(Console.ReadLine());
			Console.Write("Lütfen pozitif bir sayı giriniz: ")
			int m = int.Parse(Console.ReadLine());
			int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (m == array[i] || m % array[i] == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
		}
	}
}
// www.patika.dev







































