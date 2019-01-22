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

	// Complete the birthdayCakeCandles function below.
	static int birthdayCakeCandles(int[] arr)
	{

		Array.Sort(arr);
		int result = 1;
		int decriment = 2;
		while ((decriment <= arr.Length) && (arr[arr.Length - 1] == arr[arr.Length - decriment]))
		{
			result++;
			decriment++;
		}
		return result;

	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int arCount = Convert.ToInt32(Console.ReadLine());

		int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
		;
		int result = birthdayCakeCandles(ar);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}
