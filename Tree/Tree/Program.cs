public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Add(4);
        bst.Add(7);
        bst.Add(3);
        bst.Add(5);
        bst.Add(2);
        bst.Add(8);
        bst.Add(1);

        Console.WriteLine("Tree Visualization:");
        bst.PrintTree();
        
        Console.WriteLine("In-Order Traversal:");
        bst.InOrderTraversal();

        Console.WriteLine("Pre-Order Traversal:");
        bst.PreOrderTraversal();

        Console.WriteLine("Post-Order Traversal:");
        bst.PostOrderTraversal();
    }
}