using System;
using System.IO;
using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		String[] lines = File.ReadAllLines(@"/Users/macbook/Desktop/PTlab/Lab2/WriteText.txt");
		long score = 0;
        long min = long.MaxValue;
        ArrayList arr = new ArrayList ();
        Console.WriteLine("Input numbers:");
		foreach (String line in lines)
		{
            Console.Write(line.ToString() + " ");
		}
        Console.WriteLine("\n" + "Minimum simple number is: ");
		foreach (String line in lines)
		{
			

            if (Int64.TryParse(line, out score))
			{
                if (isSimple(score))
                {
                    arr.Add(score);
                    foreach (long scores in arr)
                    {
                        if (min > scores)
                            min = scores;
                    }
				}
			}
		}

        Console.WriteLine(min);
		using (StreamWriter file =
			new StreamWriter(@"/Users/macbook/Desktop/PTlab/Lab2/WriteText2.txt"))
        {
            file.WriteLine("\n" + "Minimum simple number is: " + min);
        }
	}

	private static bool isSimple(long N)
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