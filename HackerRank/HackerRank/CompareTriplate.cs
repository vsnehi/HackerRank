using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

	// Complete the compareTriplets function below.
	static List<int> compareTriplets(List<int> a, List<int> b)
	{
		var ScoreAlice = 0;
		var ScoreBob = 0;
		var i = 0;

		a.ForEach(scoreAlice => {
			if (a.ElementAt(i) > b.ElementAt(i))
			{
				ScoreAlice++;
			}
			else if (a.ElementAt(i) < b.ElementAt(i))
			{
				ScoreBob++;
			}


			i++;
		});
		return new List<int> { ScoreAlice, ScoreBob };

	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

		List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

		List<int> result = compareTriplets(a, b);

		textWriter.WriteLine(String.Join(" ", result));

		textWriter.Flush();
		textWriter.Close();
	}
}
