using System;

namespace TelstraTest
{
	/// <summary>
	/// Node in a tree.
	/// </summary>
	public class Node
	{
		public int Value { get; set; }
		public Node Left { get; set; }
		public Node Right { get; set; }
		public Node(int value, Node left, Node right)
		{
			Value = value;
			Left = left;
			Right = right;
		}
	}

	/// <summary>
	/// Binary search tree.
	/// </summary>
	public class BinarySearchTree
	{
		/// <summary>
		/// Determines if the tree valid BS the specified root.
		/// </summary>
		/// <returns><c>true</c> if is valid BST; otherwise, <c>false</c>.</returns>
		/// <param name="root">Root Node.</param>
		public static bool IsValidBST(Node root)
		{
			if (root == null) 
				return(true); 
			 
			if (root.Left!=null && MaxValue(root.Left) > root.Value) 
				return(false); 

			if (root.Right!=null && MinValue(root.Right) <= root.Value) 
				return(false); 

			if (!IsValidBST(root.Left) || !IsValidBST(root.Right)) 
				return(false); 

			return(true); 
		}

		/// <summary>
		/// Finds the maximum value in the sub tree. This is a reccursive fuction
		/// </summary>
		/// <returns>The value.</returns>
		/// <param name="node">Node.</param>
		static int MaxValue (Node node)
		{			
			int subNodeMaxValue =node.Right == null ? node.Value: MaxValue (node.Right);
			int maxvalue = node.Value > subNodeMaxValue?node.Value : subNodeMaxValue ;
			return maxvalue;
		}

		/// <summary>
		/// Finds the minimums value in the sub tree. - This is a reccursive fuction
		/// </summary>
		/// <returns>Minimum value in the three</returns>
		/// <param name="node">Node.</param>
		static int MinValue (Node node)
		{
			int subNodeMinValue = node.Left == null ? node.Value: MinValue (node.Left);
			int minValue = node.Value > subNodeMinValue?node.Value : subNodeMinValue ;
			return minValue;
		} 
	}
}

