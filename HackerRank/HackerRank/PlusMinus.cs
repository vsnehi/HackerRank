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

	// Complete the plusMinus function below.
	static void plusMinus(int[] arr)
	{

		int n = arr.Count();
		int ntv = 0;
		int ptv = 0;
		int ze = 0;

		float pos = arr.Count(val => val > 0);
		float neg = arr.Count(val => val < 0);
		float eal = arr.Count(val => val == 0);


		for (int c = 0; c < arr.Length; c++)
		{
			if (arr[c] < 0)
			{
				ntv = ntv + 1;
			}
			if (arr[c] > 0)
			{
				ptv = ptv + 1;
			}
			if (arr[c] == 0)
			{
				ze = ze + 1;
			}
		}
		Console.WriteLine(pos / n);
		Console.WriteLine(neg / n);
		Console.WriteLine(eal / n);

	}

	static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());

		int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
		;
		plusMinus(arr);
	}
}
