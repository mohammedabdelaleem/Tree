namespace GeneralTree;
public  class Tree<T>{
	public Node<T> Root { get; private set; }


	public Tree(T rootValue)
	{
		Root = new Node<T>(rootValue);
	}

}
