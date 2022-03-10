using System;
using System.IO;
using System.Linq;

namespace App
{
	class MyUnit2 {

		static void Main () {

			Console.OutputEncoding = System.Text.Encoding.UTF8;
			CreateArray();
			// SortBubble();
			Console.ReadKey();

		 

		}

		public static int[] CreateArray(){ // создаёт массив

			Console.Write("Размер массива: ");
			int mastsize = int.Parse(Console.ReadLine());

			int[] mast = new int[mastsize];

			for (int a = 0; a < mast.Length ; a++){
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

		public static void ShowMast(int[] mast) {

		}

		public int SortBubble(int[] mast){ // примает массив

			int result = 0;

			for (int a = 0; a < mast.Length ; a++) { // сортировка пызырьком
				for (int b = 0; b < mast.Length-1-a; b++) {

					if (mast[b] > mast[b++]) {
						int c = mast[b];
						mast[b] = mast[b++];
						mast[b++] = c;

					}
				}
				
			}

			return result;
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