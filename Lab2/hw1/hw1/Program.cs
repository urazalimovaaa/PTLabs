using System;
using System.IO;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
		String[] lines = File.ReadAllLines(@"/Users/macbook/Desktop/PTlab/Lab2/WriteText.txt");
        long max = long.MinValue;
        long min = long.MaxValue;
		long score = 0;
        Console.Write("Input numbers:");
		foreach (String line in lines)
		{
            Console.WriteLine(line);

			if (Int64.TryParse(line, out score))
			{
				if (score > max)
					max = score;
                if (score < min)
                    min = score;
			}
		}
		Console.WriteLine("\n" + "Maximum Score is " + max);
        Console.WriteLine("\n" + "Minimum Score is " + min);



	}


}
