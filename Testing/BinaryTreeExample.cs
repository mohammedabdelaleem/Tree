using BinaryTree;
public class BinaryTreeExample
{
	public static void Main(string[] args)
	{
		var binaryTree = new BinaryTree<int>();
		Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9\n");

		binaryTree.Insert(5);
		binaryTree.Insert(3);
		binaryTree.Insert(8);
		binaryTree.Insert(1);
		binaryTree.Insert(4);
		binaryTree.Insert(6);
		binaryTree.Insert(9);


		// Tree Traversal : 
		// 01 - PreOrder (DFS)
		// 02 - PostOrder 
		// 03 - InOrder 
		// 04 - Level-Order (BFS) 


		binaryTree.PrintTree();

		Console.WriteLine("\n=========================\n");
		Console.WriteLine("PreOrder Traversal (Current - Left SubTree - Right SubTree) :>");
		binaryTree.PreOrderTraversal();

		Console.WriteLine("\n=========================\n");
		Console.WriteLine("PostOrder Traversal ( Left SubTree - Right SubTree - Current ) :>");
		binaryTree.PostOrderTraversal();

		Console.WriteLine("\n=========================\n");
		Console.WriteLine("InOrder Traversal ( Left SubTree - Current - Right SubTree ) :>");
		binaryTree.InOrderTraversal();

		Console.WriteLine("\n=========================\n");
		Console.WriteLine("Level Order Traversal [BFS] ( Left SubTree - Current - Right SubTree ) :>");
		binaryTree.LevelOrderTraversal_BFS();

		Console.ReadKey();
	}
}