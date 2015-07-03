using System;

namespace TelstraTest
{
	/// <summary>
	/// Math utils.
	/// </summary>
	public class MathUtils
	{ 

		/// <summary>
		/// Average the specified a and b.
		/// </summary>
		/// <param name="a">Input number 1.</param>
		/// <param name="b">Input number 2.</param>
		public static double Average(int a, int b)
		{
			// Type casting the sum before dividing, To get the result in double. 
			return (double) (a + b) / 2;
		}

	}
}

