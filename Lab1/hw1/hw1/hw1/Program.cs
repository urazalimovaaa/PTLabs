using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW1
{

	class MainClass
	{
		public static void Main(string[] args)
		{
			int n, i;
			Console.Write("Number of enters: ");
			n = int.Parse(Console.ReadLine());
			int[] numbers = new int[n];
			Console.WriteLine("Enter numbers: ");
			string[] s = Console.ReadLine().Split(' ');
			for (i = 0; i < s.Length; i++)
			{

				numbers[i] = int.Parse(s[i]);

				if (isPrime(i))
					Console.Write(i.ToString() + " ");

			}

		}


		public static bool isPrime(int i)
		{
			if (i == 1)
				return false;
			if (i == 2)
				return true;

			for (int j = 3; j * j <= i; j++)
			{
				if (i % j == 0)
					return false;
			}
			return true;


		}
	}
}
