using System;
using System.Linq;

namespace Day2
{
	class Program
	{
		public int CalcCorruptionChecksumMinMax(string input)
		{
			int sum = 0;
			var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			foreach (var line in lines)
			{
				var numbers = line.Split('\t');
				int min = Int32.Parse(numbers.FirstOrDefault());
				int max = min;
				foreach (var number in numbers)
				{
					var value = Int32.Parse(number);
					if (value < min)
					{
						min = value;
					}
					else if(value > max)
					{
						max = value;
					}
				}
				sum += (max - min);
			}
			return sum;
		}

		public int CalcCorruptionChecksumMod(string input)
		{
			int sum = 0;
			var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			foreach (var line in lines)
			{
				var numbers = line.Split('\t');
				foreach (var firstNumber in numbers)
				{
					var firstValue = Int32.Parse(firstNumber);
					foreach (var secondNumber in numbers)
					{
						var secondValue = Int32.Parse(secondNumber);
						if (firstValue != secondValue && firstValue % secondValue == 0)
						{
							sum += (firstValue / secondValue);
						}
					}
				}
			}
			return sum;
		}

		static void Main(string[] args)
		{
			var input = System.IO.File.ReadAllText(@"Input.txt");
			var p = new Program();
			Console.WriteLine(p.CalcCorruptionChecksumMinMax(input));
			Console.WriteLine(p.CalcCorruptionChecksumMod(input));
			Console.ReadLine();
		}
	}
}
