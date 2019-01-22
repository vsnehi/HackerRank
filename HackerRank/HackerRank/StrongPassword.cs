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

	// Complete the minimumNumber function below.
	static int minimumNumber(int n, string password)
	{
		// Return the minimum number of characters to make the password strong
		int lc = 0, uc = 0, no = 0, sc = 0;
		int sum = 0;

		int success = 0;
		string num = "0123456789";
		string lowercase = "abcdefghijklmnopqrstuvwxyz";
		string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		string specialchar = "!@#$%^&*()-+";
		bool digit = false;
		bool lower = false;
		bool upper = false;
		bool special = false;

		for (int x = 0; x < password.Length; x++)
		{
			if (num.Contains(password.Substring(x, 1))) { digit = true; }
			if (lowercase.Contains(password.Substring(x, 1))) { lower = true; }
			if (uppercase.Contains(password.Substring(x, 1))) { upper = true; }
			if (specialchar.Contains(password.Substring(x, 1))) { special = true; }
		}
		if (!digit) { success++; }
		if (!lower) { success++; }
		if (!upper) { success++; }
		if (!special) { success++; }
		if (success + password.Length < 6)
		{
			success = 6 - password.Length;
		}
		return success;
	}

	static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine());

		string password = Console.ReadLine();

		int answer = minimumNumber(n, password);

		textWriter.WriteLine(answer);

		textWriter.Flush();
		textWriter.Close();
	}
}
