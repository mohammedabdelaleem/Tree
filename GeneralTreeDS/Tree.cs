namespace GeneralTreeDS;
public  class Tree<T>{
	public Node<T> Root { get; private set; }


	public Tree(T rootValue)
	{
		Root = new Node<T>(rootValue);
	}

	public void Print()
	{
		Print(Root); 
	}

	public Node<T>? Find(T value)
	{
		return Root?.Find(value);
	}

	public Node<T> Max(IComparer<T> comparer)
	{
		return Root.Max(comparer);
	}
	public Node<T> Min(IComparer<T> comparer)
	{
		return Root.Min(comparer);
	}

	private void Print<T>(Node<T> node, string identation="")
	{
		Console.WriteLine($"{identation}{node.Value}");

		foreach (var child in node.Children)
		{
			Print(child, identation+"--");
		}
	}


}
