using System;

namespace TelstraTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{			
			try {
				//Average - Question 1
//				var result = MathUtils.Average (0, 0);
//				Console.WriteLine ("Average is  :{0}", result);
//				Console.Read();

				// Question 2 - Path, CD Command
				Path path = new Path("/a/b/c/d");
				//Path path = new Path("/");
				Console.WriteLine(path.Cd("../x").CurrentPath);
				Console.ReadLine (); 
			
				// Question 3 - Find index of maximum number of reccuring alphabet
//				Console.WriteLine(Run.IndexOfLongestRun("abbcccddddcccbba"));
//				Console.WriteLine(Run.IndexOfLongestRun("aaaacrrrrrrrrgg"));
//				Console.ReadLine ();

				// Question 4 - BST validation
//				Node n1 = new Node(11, null, null);
//				n1.Left=new Node(13,null,null);
//				n1.Right=new Node(6,null,null);
//				Node n3 = new Node(25, null, null);
//				Node n2 = new Node(20, n1, n3);
//				Console.WriteLine(BinarySearchTree.IsValidBST(n2));
//				Console.ReadLine ();
			} catch (ApplicationException ex) {
				Console.WriteLine ("Unknown Exception occured {0}", ex.Message);
				Console.ReadLine ();
			}


		}
	}


}
