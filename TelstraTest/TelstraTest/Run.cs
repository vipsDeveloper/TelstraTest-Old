using System;
using System.Text.RegularExpressions;

namespace TelstraTest
{
	/// <summary>
	/// Run.
	/// </summary>
	public class Run
	{
		/// <summary>
		/// Finds the 0 based index of maximum reccuring charecter.
		/// </summary>
		/// <returns>Start Index of the maximum reccuring charecter.</returns>
		/// <param name="str">String.</param>
		public static int IndexOfLongestRun(string str)
		{  
			if (string.IsNullOrEmpty (str.Trim())) {
				return -1;
			}

			int currentLargest = 0; 
			int returnIndex =0;

			MatchCollection result = Regex.Matches (str, "(\\w)\\1+");
			foreach(Match item in result)
			{
				if (currentLargest < item.Length) {
					returnIndex = item.Index;
					currentLargest = item.Length;
				}
			}	
			return returnIndex;

		}
	}
}

