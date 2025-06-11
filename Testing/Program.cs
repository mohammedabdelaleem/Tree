


using GeneralTreeDS;

var family = new Tree<string>("Abd El-Daym");

var grand_grand_pa = new Node<string>("Mohammed");
family.Root.AddChild(grand_grand_pa);

var grand_pa = new Node<string>("Mostafa");

grand_grand_pa.AddChild(grand_pa);
grand_grand_pa.AddChild(new Node<string>("El-Shat"));
grand_grand_pa.AddChild(new Node<string>("Hafez"));
grand_grand_pa.AddChild(new Node<string>("Ataa"));
grand_grand_pa.AddChild(new Node<string>("Koukab"));
grand_grand_pa.AddChild(new Node<string>("El-Set"));

var pa = new Node<string>("Abd El-Aleem");
var uncle = new Node<string>("Mohammed");

grand_pa.AddChild(pa);
grand_pa.AddChild(uncle);
grand_pa.AddChild(new Node<string>("Sasa1"));
grand_pa.AddChild(new Node<string>("Helmy"));
grand_pa.AddChild(new Node<string>("Rsha"));

pa.AddChild(new Node<string>("Mohammed"));
pa.AddChild(new Node<string>("Ahmed"));
pa.AddChild(new Node<string>("Sasa2"));

uncle.AddChild(new Node<string>("Wafaaaa"));
uncle.AddChild(new Node<string>("Sasa3"));
uncle.AddChild(new Node<string>("Helmy"));
uncle.AddChild(new Node<string>("Ahmed2"));


family.Root.PrintTree();

