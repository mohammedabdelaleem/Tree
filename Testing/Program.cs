
using GeneralTreeDS;

// Creating the tree
var CompanyTree = new Tree<string>("CEO");
var Finance = new Node<string>("CFO");
var Tech = new Node<string>("CTO");
var Marketing = new Node<string>("CMO");


// Adding departments to the CEO node
CompanyTree.Root.AddChild(Finance);
CompanyTree.Root.AddChild(Tech);
CompanyTree.Root.AddChild(Marketing);


// Adding employees to departments
Finance.AddChild(new Node<string>("Accountant"));
Tech.AddChild(new Node<string>("Developer"));
Tech.AddChild(new Node<string>("UX Designer"));
Marketing.AddChild(new Node<string>("Social Media Manager"));

// Printing the tree
CompanyTree.Print();


Console.WriteLine("\nFinding Developer...");
if (CompanyTree.Find("Developer".ToLower()) == null)
	Console.WriteLine("Not Found :-(");
else
	Console.WriteLine("Found :-)");

Console.WriteLine("\nFinding DBA...");
if (CompanyTree.Find("DBA") == null)
	Console.WriteLine("Not Found :-(");
else
	Console.WriteLine("Found :-)");

Console.ReadKey();

