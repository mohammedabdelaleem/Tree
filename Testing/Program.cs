
using GeneralTreeDS;


var root = new Node<int>(10);
root.AddChild(new Node<int>(25));
root.AddChild(new Node<int>(5));
root.Children[0].AddChild(new Node<int>(50));
root.Children[0].AddChild(new Node<int>(500));
root.Children[1].AddChild(new Node<int>(-50));

var maxNode = root.Max(Comparer<int>.Default);
var minNode = root.Min(Comparer<int>.Default);

Console.WriteLine($"Max value: {maxNode.Value}"); 
Console.WriteLine($"Max value: {minNode.Value}"); 


Console.ReadLine();