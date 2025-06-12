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


	private void Print<T>(Node<T> node, string identation="")
	{
		Console.WriteLine($"{identation}{node.Value}");

		foreach (var child in node.Children)
		{
			Print(child, identation+"--");
		}
	}


}
