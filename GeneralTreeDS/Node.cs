namespace GeneralTreeDS;
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

public Node<T>? Find(T value)
	{
		if (typeof(T) == typeof(string))
		{
			if (string.Equals(Value as string, value as string, StringComparison.OrdinalIgnoreCase))
				return this;
		}
		else
		{
			if (EqualityComparer<T>.Default.Equals(Value, value))
				return this;
		}

		foreach (var child in Children)
		{
			var found = child.Find(value); // child will be the root of the current subtree
			if(found !=null) return found;
		}

		return null;
	}
	
}
