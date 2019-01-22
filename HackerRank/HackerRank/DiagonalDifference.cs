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

	// Complete the diagonalDifference function below.
	static int diagonalDifference(int[][] arr)
	{

		int row = 0;
		int column = arr[0].Length - 1;
		int solution = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			solution -= arr[row][row] - arr[row++][column--];
		}
		return Math.Abs(solution);

	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		int[][] arr = new int[n][];

		for (int i = 0; i < n; i++)
		{
			arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
		}

		int result = diagonalDifference(arr);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}
