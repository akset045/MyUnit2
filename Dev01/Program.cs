using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace App{

	class MyUnit2{

		public void ShowAAll(int[] arr)
		{
			Console.WriteLine($"\nИтоговый массив:");
			for (int a = 0; a < arr.Length; a++)
			{
				Console.Write($"{arr[a]}");
				if (a < arr.Length - 1)
				{
					Console.Write("; ");
				}
				else if (a == arr.Length - 1)
				{
					Console.Write(".");
				}
			}
		}

		public static void ShowAUlt(int[] arr)
		{
			Console.Write($"\nМаксимум: {arr.Max()}; Минимум: {arr.Min()}");
		}

		public void SortBubble(int[] arr)
		{ // примает массив
			for (int a = 0; a < arr.Length; a++)
			{ // сортировка пузырьком
				for (int b = 0; b < arr.Length - 1 - a; b++)
				{
					if (arr[b] > arr[b++])
					{
						int c = arr[b];
						arr[b] = arr[b++];
						arr[b++] = c;
					}
				}
			}
		}

		public static int[] CreateAAut()
		{ // создаёт массив авто

			Console.Write("Размер массива: ");
			int mastsize = int.Parse(Console.ReadLine());

			var newA = new Random();
			var mast = new int[mastsize];

			for (int a = 0; a < mast.Length; a++)
			{
				mast[a] = newA.Next(mastsize);
			}

			ShowAAll(mast);

			return mast;

		}

		public static int[] CreateAMan()
		{ // создаём массив в ручную

			Console.Write("Размер массива: ");
			int mastsize = int.Parse(Console.ReadLine());

			int[] mast = new int[mastsize];
			for (int a = 0; a < mast.Length; a++)
			{
				Console.Write($"Введите элемент №{a}: ");
				mast[a] = int.Parse(Console.ReadLine());
			}
			return mast;
		}


		static public void Main()
		{

			NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
			{
				NumberDecimalSeparator = "."
			};

			Console.OutputEncoding = System.Text.Encoding.UTF8;


			static int[] MakeA()
			{

				switch (Console.ReadLine())
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

				return mast;

			}


			ShowAAll(mast);

			Console.ReadKey();
		}

	}
}
