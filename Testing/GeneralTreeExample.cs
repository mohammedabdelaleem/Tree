using GeneralTreeDS;

public class GeneralTreeExample
{
	public static void Main0(string[] args)
	{
		var intTree = new Tree<int>(1000);


		intTree.Root.AddChild(new Node<int>(25));
		intTree.Root.AddChild(new Node<int>(5));
		intTree.Root.Children[0].AddChild(new Node<int>(50));
		intTree.Root.Children[0].AddChild(new Node<int>(50000));
		intTree.Root.Children[0].AddChild(new Node<int>(50000));
		intTree.Root.Children[0].AddChild(new Node<int>(60000));
		intTree.Root.Children[0].AddChild(new Node<int>(550000));
		intTree.Root.Children[0].AddChild(new Node<int>(10000));
		intTree.Root.Children[0].AddChild(new Node<int>(510000));
		intTree.Root.Children[0].AddChild(new Node<int>(502000));
		intTree.Root.Children[0].AddChild(new Node<int>(50000));
		intTree.Root.Children[0].AddChild(new Node<int>(510000));
		intTree.Root.Children[0].AddChild(new Node<int>(5120000));
		intTree.Root.Children[0].AddChild(new Node<int>(50000));
		intTree.Root.Children[0].AddChild(new Node<int>(520000));
		intTree.Root.Children[0].AddChild(new Node<int>(570000));
		intTree.Root.Children[0].AddChild(new Node<int>(-750000));
		intTree.Root.Children[0].AddChild(new Node<int>(550000));
		intTree.Root.Children[1].AddChild(new Node<int>(-50));

		var maxNode = intTree.Max(Comparer<int>.Default);
		var minNode = intTree.Min(Comparer<int>.Default);

		Console.WriteLine($"Max value: {maxNode.Value}");
		Console.WriteLine($"Max value: {minNode.Value}");


		Console.ReadLine();
	}
}