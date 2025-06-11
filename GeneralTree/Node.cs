namespace GeneralTree;
public sealed class Node<T>
{
	// node has
	// 01 - its value
	// 02 - children


	public T Value { get; set; }
	public List<Node<T>> Children { get; set; }

	public Node(T value)
	{
		Value = value;
		Children = new List<Node<T>>();
	}

	public void AddChild(Node<T> node)=>Children.Add(node);
	
}
