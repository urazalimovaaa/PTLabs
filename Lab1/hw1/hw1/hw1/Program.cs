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
            int n;
            Console.Write("Number of enters: ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Enter numbers: ");
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {

                numbers[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
			{

                if (isSimple(numbers[i]))
				{
                    Console.Write(numbers[i].ToString() + " ");
				}
			}
        }
		private static bool isSimple(int N)
		{
            if (N == 1 || N == 0)
                return false;
            
            for (int j = 2; j <= (int)(N / 2); j++)
              {
                    if (N % j == 0)
                        return false;
              }
            return true;
         
		}
       
    }
}
