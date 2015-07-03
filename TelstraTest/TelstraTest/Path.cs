using System;
using System.Text.RegularExpressions;

namespace TelstraTest
{
	/// <summary>
	/// Path.
	/// </summary>
	public class Path
	{
		public string CurrentPath { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TelstraTest.Path"/> class.
		/// </summary>
		/// <param name="path">Path.</param>
		public Path(string path)
		{
			this.CurrentPath = path;
		}

		/// <summary>
		/// Change directroy operation
		/// </summary>
		/// <param name="newPath">New path.</param>
		public Path Cd(string newPath)
		{
			// Validating the input path.
			if (Regex.IsMatch(newPath, @"^\.{2}/[A-z]+")) {
				var NewDirectory = newPath.Substring (newPath.LastIndexOf ('/'));
				if (string.Compare (CurrentPath, "/") == 0) {
					// TODO:: as the empty case is not define in the requirement,
					// currently if current path is root directory, new directry will be changed to subdirectory to root

					// Performing the string replacement and string concatination in the path.
					string NewDirectoryPath = string.Format ("{0}{1}", CurrentPath, NewDirectory.Replace("/",string.Empty));
					return new Path (NewDirectoryPath); 
				}

				// return the input path a just the subdirectory to the root.
				var returnValue = string.Format("{0}{1}",CurrentPath.Substring(0, CurrentPath.LastIndexOf('/')),NewDirectory);
				return new Path (returnValue); ;
			}

			throw new ApplicationException ("Invalid path entered");
		} 
	}
}

