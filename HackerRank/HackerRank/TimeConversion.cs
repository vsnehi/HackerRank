using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

	/*
     * Complete the timeConversion function below.
     */
	static string timeConversion(string time)
	{

		var amOrPm = time.Substring(8);
		var hourComponent = time.Substring(0, 2);
		var remainingTimeComponent = time.Substring(2, 6);
		if (amOrPm == "AM" && hourComponent == "12")
		{
			hourComponent = "00";
		}
		else if (amOrPm == "PM")
		{
			var numericHourComponent = int.Parse(hourComponent);
			if (numericHourComponent != 12)
			{
				hourComponent = Convert.ToString(12 + numericHourComponent);
			}
		}
		return hourComponent + remainingTimeComponent;

	}

	static void Main(string[] args)
	{
		TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		string s = Console.ReadLine();

		string result = timeConversion(s);

		tw.WriteLine(result);

		tw.Flush();
		tw.Close();
	}
}
