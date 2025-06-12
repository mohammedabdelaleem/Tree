namespace BinaryTree;
public class BinaryTree<T>
{
	public Node<T> Root { get; private set; }


	public BinaryTree()
	{
		Root = null!;
	}


	public void Insert(T value)
	{


		/*
		 We use Level-order insertion strategy,
		 [fill level from left to right , binary tree each node has at most 2 nodes]
		 Level-order insertion: in a binary tree is a strategy that fills the tree level by level, 
		 from left to right. This approach ensures that every level of the tree is completely 
		 filled before any nodes are added to a new level, 
		 and each parent node has at most two children before moving on to the next node in the 
		 sequence.
		 */



		// Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9,11\n");
		// prepare the node with the comming value
		var newNode = new Node<T>(value);

		if (Root == null) // If the tree is empty, set the new node as the root
		{
			Root = newNode;
			return;
		}


		// Use a queue to perform level-order insertion
		Queue<Node<T>> queue = new Queue<Node<T>>();
		queue.Enqueue(Root);

		while (queue.Count > 0)
		{
			var current = queue.Dequeue();


			// Attempt to insert the new node in the first empty spot in level order
			if (current.Left == null)
			{
				current.Left = newNode;
				break;
			}
			else // Otherwise, enqueue it to check its children later.
			{
				queue.Enqueue(current.Left);
			}


			if (current.Right == null)
			{
				current.Right = newNode;
				break;
			}
			else
			{
				queue.Enqueue(current.Right);
			}
		}
	}


	public void PrintTree()
	{
		PrintTree(Root, 0);
	}
	private void PrintTree(Node<T> root, int space)
	{
		int COUNT = 10;  // Distance between levels to adjust the visual representation
		if (root == null)
			return;


		space += COUNT;
		PrintTree(root.Right, space); // Print right subtree first, then root, and left subtree last


		Console.WriteLine();
		for (int i = COUNT; i < space; i++)
			Console.Write(" ");
		Console.WriteLine(root.Value); // Print the current node after space


		PrintTree(root.Left, space); // Recur on the left child
	}


	private void PreOrderTraversal(Node<T> node)
	{
		/*
		  PreOrder Traversal visits the current node before its child nodes. 
		  The process for PreOrder Traversal is as follows:


			 - Visit the current node.
			 - Recursively perform PreOrder Traversal of the left subtree.
			 - Recursively perform PreOrder Traversal of the right subtree.
		*/


		if (node != null)
		{
			Console.Write($"{node.Value} ,");
			PreOrderTraversal(node.Left);
			PreOrderTraversal(node.Right);
		}

	}
	public void PreOrderTraversal()
	{
		PreOrderTraversal(Root);
		Console.Write("\b\b  \b\b"); // erase the last comma and space		
		Console.WriteLine(" ");
	}


	private void PostOrderTraversal(Node<T> node)
	{
		/*
		 *  the left subtree
		 *  the right subtree
		 *  node
		*/


		if (node != null)
		{
			PostOrderTraversal(node.Left);
			PostOrderTraversal(node.Right);
			Console.Write($"{node.Value} ,");
		}

	}
	public void PostOrderTraversal()
	{
		PostOrderTraversal(Root);
		Console.Write("\b\b  \b\b"); // erase the last comma and space		
		Console.WriteLine(" ");
	}


	private void InOrderTraversal(Node<T> node)
	{
		/*
		 *  the left subtree
		 *  the right subtree
		 *  node
		*/


		if (node != null)
		{
			InOrderTraversal(node.Left);
			Console.Write($"{node.Value} ,");
			InOrderTraversal(node.Right);
		}

	}
	public void InOrderTraversal()
	{
		InOrderTraversal(Root);
		Console.Write("\b\b  \b\b"); // erase the last comma and space		
		Console.WriteLine(" ");
	}

	public void LevelOrderTraversal_BFS()
	{
		if (Root == null) return;


		var queue = new Queue<Node<T>>();
		queue.Enqueue(Root);

		while (queue.Count > 0)
		{
			var current = queue.Dequeue();

			Console.Write(current.Value + " ");	

			if(current.Left != null)
				queue.Enqueue(current.Left);

			if(current.Right != null)
				queue.Enqueue(current.Right);

		}
	}

}