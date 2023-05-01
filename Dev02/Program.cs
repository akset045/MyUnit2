using System;

namespace main {

	class app {

		public double expoD(double a, double b) {

			double x = a / b;
			return x;

    }

		static void Main(string[] args) {

			while (true) {
				Console.OutputEncoding = System.Text.Encoding.UTF8;

				Console.Write("Введите A: ");
				double a = double.Parse(Console.ReadLine());
				Console.Write("Введите B: ");
				double b = double.Parse(Console.ReadLine());

				static double expoD(double a1, double a2) {
					double x = a1 / a2;
					return x;
				}

				Console.WriteLine($"---\nРезультат: {expoD(a,b)}\n");
			}

			Console.ReadKey();

		}


	}





}
