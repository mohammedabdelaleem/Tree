using System.Xml.Linq;

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
	
	public Node<T> Max(IComparer<T> comparer) 
	{
		#region simple understanding
		/*
		Root is initially the max
		For each child, say:
		“Give me the max node from your subtree.”
		Then: “I'll compare it with my own value.”
		If the child has no children, it returns itself.
		Then the parent compares its own value to that child’s max and updates if needed.
		[if the parent has 2 children compare its value with the first and update if needed then compare the current value with next child]
		This repeats recursively until all branches have been checked.
		*/
		#endregion

		Node<T> maxNode = this;

		foreach (var child in Children)
		{
			var childMax = child.Max(comparer);

			if(comparer.Compare(childMax.Value, maxNode.Value) > 0)
				maxNode = childMax;
		}

		return maxNode;
	}

	public Node<T> Min(IComparer<T> comparer)
	{

		Node<T> minNode = this;

		foreach (var child in Children)
		{
			var childMin = child.Min(comparer);

			if (comparer.Compare(childMin.Value, minNode.Value) < 0)
				minNode = childMin;
		}

		return minNode;
	}

}
