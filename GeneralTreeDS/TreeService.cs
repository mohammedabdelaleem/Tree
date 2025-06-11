namespace GeneralTreeDS;
public static class TreeService
{
	public static void PrintTree<T>(this Node<T> node, string indent = "")
	{
		Console.WriteLine(indent + node.Value);

		foreach (var child in node.Children)
		{
			PrintTree(child, indent + "---");
		}
	}
}
