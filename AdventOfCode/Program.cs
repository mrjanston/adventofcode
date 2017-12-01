using System;

class Program
{
	public int CalculateHalfway(string input)
	{
		int sum = 0;
		for (int i = 0; i < input.Length / 2; ++i)
		{
			sum += input[i] == input[i + input.Length / 2] ? (int)Char.GetNumericValue(input[i]) * 2 : 0;
		}
		return sum;
	}

	public int CalculateNextNumber(string input)
	{
		int sum = 0;
		for (int i = 0; i < input.Length - 1; ++i)
		{		
			sum += input[i] == input[i + 1] ? (int)Char.GetNumericValue(input[i]) : 0;
		}
		return sum += input[0] == input[input.Length-1] ? (int)Char.GetNumericValue(input[0]) : 0;
	}

	public static void Main(string[] args)
    {
		var p = new Program();
		var input = System.IO.File.ReadAllText(@"Input.txt");
		Console.WriteLine(p.CalculateNextNumber(input));
		Console.WriteLine(p.CalculateHalfway(input));		
		Console.ReadLine();
    }   
}