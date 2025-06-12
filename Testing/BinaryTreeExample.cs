using BinaryTree;
public class BinaryTreeExample
{
	public static void Main(string[] args)
	{
		var binaryTree = new BinaryTree<int>();
		Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9,11\n");

		binaryTree.Insert(5);
		binaryTree.Insert(3);
		binaryTree.Insert(8);
		binaryTree.Insert(1);
		binaryTree.Insert(4);
		binaryTree.Insert(6);
		binaryTree.Insert(9);
		binaryTree.Insert(11);

		
		binaryTree.PrintTree();

		Console.WriteLine("\n=========================\n");
		Console.WriteLine("PreOrder Traversal (Current - Left SubTree - Right SubTree) :>");
		binaryTree.PreOrderTraversal();



		Console.ReadKey();
	}
}