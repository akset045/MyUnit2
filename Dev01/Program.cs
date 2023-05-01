using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace App{

	class MyUnit2{

		/// <summary>
		/// Показывает весь массив.
		/// </summary>
		/// <param name="arr"></param>
		public static void ShowAAll(int[] arr)
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

		/// <summary>
		/// Показывает максимум и минимум массива.
		/// </summary>
		/// <param name="arr"></param>
		public static void ShowAUlt(int[] arr)
		{
			Console.Write($"\nМаксимум: {arr.Max()}; Минимум: {arr.Min()}");
		}

		/// <summary>
		/// Отсортировать массив методом пузырька.
		/// </summary>
		/// <param name="arr"></param>
		public static void SortBubble(int[] arr)
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

		/// <summary>
		///  Создаёт массив автоматически.
		/// </summary>
		/// <returns></returns>
		public static int[] CreateAAut()
		{
			Console.Write("Размер массива: ");
			int.TryParse(Console.ReadLine(),out int mastsize);

			var newA = new Random();
			var mast = new int[mastsize];

			for (int a = 0; a < mast.Length; a++)
			{
				mast[a] = newA.Next(mastsize);
			}

			ShowAAll(mast);

			return mast;

		}

		/// <summary>
		/// Создаём массив в ручную.
		/// </summary>
		/// <returns></returns>
		public static int[] CreateAMan()
		{ 
			Console.Write("Размер массива: ");
			int.TryParse(Console.ReadLine(), out int mastsize);

			int[] mast = new int[mastsize];
			for (int a = 0; a < mast.Length; a++)
			{
				Console.Write($"Введите элемент №{a}: ");
				int.TryParse(Console.ReadLine(), out mast[a]);
			}

			return mast;
		}


		public static void Main()
		{

			NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
			{
				NumberDecimalSeparator = "."
			};

			Console.OutputEncoding = System.Text.Encoding.UTF8;

			while (true)
            {
				CreateAAut();
				Console.Write($"\n");



				//int[] MakeA()
				//{

				//    switch (Console.ReadLine())
				//    {
				//        case "1":
				//            CreateAAut();
				//            break;

				//        case "2":
				//            CreateAMan();
				//            break;

				//        default:
				//            Console.WriteLine("Что-то другое?");
				//            break;

				//    }

				//    return mast;

				//}

				//ShowAAll(mast);

				Console.ReadKey();


			}

		}

	}
}
