using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace App
{

	class MyUnit2 {

		
		static public void Main (string[] args) {

			NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
			{
				NumberDecimalSeparator = ".",
			};

			Console.OutputEncoding = System.Text.Encoding.UTF8;

			Console.Write("Размер массива: ");
			int mastsize = int.Parse(Console.ReadLine());

			int[] mast = new int[mastsize];

			for (int a = 0; a < mast.Length; a++)
			{
				Console.Write($"Введите элемент №{a}: ");
				mast[a] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine($"\nИтоговый массив:");

			for (int a = 0; a < mast.Length; a++)
			{
				Console.Write($"{mast[a]}");
				if (a < mast.Length - 1)
				{
					Console.Write("; ");
				}
				else if (a == mast.Length - 1)
				{
					Console.Write(".");
				}
			}

			foreach (int a in mast)
			{
				Console.Write($"{a}");
			}

			Console.ReadKey();
		}

		public static int[] CreateArray(){ // создаёт массив

            Console.Write("Размер массива: ");
            int mastsize = int.Parse(Console.ReadLine());

            int[] mast = new int[mastsize];

            for (int a = 0; a < mast.Length; a++)
            {
                Console.Write($"Введите элемент №{a}: ");
                mast[a] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nИтоговый массив:");

			for (int a = 0; a < mast.Length; a++)
			{
				Console.Write($"{mast[a]}");
				if (a < mast.Length-1){
					Console.Write("; ");
				}
				else if (a == mast.Length-1){
					Console.Write(".");
				}
			}

			Console.Write($"\nМаксимум: {mast.Max()}; Минимум: {mast.Min()}");

			return mast;
		   
		}

		public static void ShowMast(int[] array) {

			foreach (int a in array) {

				Console.Write($"{0}", a);
			}

		}

		public void SortBubble(int[] array){ // примает массив

			for (int a = 0; a < array.Length ; a++) { // сортировка пызырьком
				for (int b = 0; b < array.Length-1-a; b++) {

					if (array[b] > array[b++]) {
						int c = array[b];
						array[b] = array[b++];
						array[b++] = c;

					}
				}
				
			}

		}

		static void Fart(string[] args) {

			string? ant = Console.ReadLine();
			int bant = Int32.Parse(ant);
			int anx = Int32.Parse(ant);

			for (; anx < 1000; anx++) {

				bant++;
				Console.WriteLine($"{bant}");
			}
		}
	}
}