using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace App {

	class MyUnit2 {

    // public static int[] CreateAAut(){ // создаёт массив авто

		// 	Console.Write("Размер массива: ");
		// 	int mastsize = int.Parse(Console.ReadLine());

		// 	var newA = new Random ();
    // 		var mast = new int[mastsize];

    // 		for (int a = 0; a < mast.Length; a++){
    //     	mast[a] = newA.Next(mastsize);
    // 		}
		// 	ShowAAll(mast);

		// 	return mast;

		// }

		// public static int[] CreateAMan(){ // создаём массив в ручную

		// 	Console.Write("Размер массива: ");
		// 	int mastsize = int.Parse(Console.ReadLine());

    //   int[] mast = new int[mastsize];
    //   for (int a = 0; a < mast.Length; a++){
    //     Console.Write($"Введите элемент №{a}: ");
    //     mast[a] = int.Parse(Console.ReadLine());
		// 	}
		// 	return mast;
		// }

		public static void ShowAAll(int[] mast) {

			Console.WriteLine($"\nИтоговый массив:");
			for (int a = 0; a < mast.Length; a++){
				Console.Write($"{mast[a]}");
				if (a < mast.Length-1){
					Console.Write("; ");
				}
				else if (a == mast.Length-1){
					Console.Write(".");
				}
			}

		}

		public static void ShowAUlt(int[]mast) {

			Console.Write($"\nМаксимум: {mast.Max()}; Минимум: {mast.Min()}");
		}

		public void SortBubble(int[] mast){ // примает массив
			for (int a = 0; a < mast.Length ; a++) { // сортировка пузырьком
				for (int b = 0; b < mast.Length-1-a; b++) {
					if (mast[b] > mast[b++]) {
						int c = mast[b];
						mast[b] = mast[b++];
						mast[b++] = c;
					}
				}
			}
		}

		// static void Fart(string[] args) {

		// 	string? ant = Console.ReadLine();
		// 	int bant = Int32.Parse(ant);
		// 	int anx = Int32.Parse(ant);

		// 	for (; anx < 1000; anx++) {

		// 		bant++;
		// 		Console.WriteLine($"{bant}");
		// 	}
		// }

		static public void Main()
		{

			NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
			{
				NumberDecimalSeparator = "."
			};

			Console.OutputEncoding = System.Text.Encoding.UTF8;

			static int[] CreateAAut(){ // создаёт массив авто

				Console.Write("Размер массива: ");
				int mastsize = int.Parse(Console.ReadLine());

				var newA = new Random();
				var mast = new int[mastsize];

				for (int a = 0; a < mast.Length; a++){
					mast[a] = newA.Next(mastsize);
				}
				ShowAAll(mast);

				return mast;

			}

			static int[] CreateAMan(){ // создаём массив в ручную

				Console.Write("Размер массива: ");
				int mastsize = int.Parse(Console.ReadLine());

				int[] mast = new int[mastsize];
				for (int a = 0; a < mast.Length; a++){
					Console.Write($"Введите элемент №{a}: ");
					mast[a] = int.Parse(Console.ReadLine());
				}
				return mast;
			}

			switch(Console.ReadLine())
			{
				case "1":
					CreateAAut();
					break;

				case "2":
					CreateAMan();
					break;

				default:
					Console.WriteLine("Что-то другое?");
					break;

			}

			Console.ReadKey();
		}

	}
}
