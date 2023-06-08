public class BinarySearchTree
{
    private Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    public void Add(int value)
    {
        root = AddRecursive(root, value);
    }

    private Node AddRecursive(Node current, int value)
    {
        if (current == null)
        {
            return new Node(value);
        }

        if (value < current.Value)
        {
            current.Left = AddRecursive(current.Left, value);
        }
        else if (value > current.Value)
        {
            current.Right = AddRecursive(current.Right, value);
        }

        return current;
    }

    public void InOrderTraversal()
    {
        InOrderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void InOrderTraversalRecursive(Node node)
    {
        if (node == null)
        {
            return;
        }

        InOrderTraversalRecursive(node.Left);
        Console.Write(node.Value + " ");
        InOrderTraversalRecursive(node.Right);
    }

    public void PreOrderTraversal()
    {
        PreOrderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void PreOrderTraversalRecursive(Node node)
    {
        if (node == null)
        {
            return;
        }

        Console.Write(node.Value + " ");
        PreOrderTraversalRecursive(node.Left);
        PreOrderTraversalRecursive(node.Right);
    }

    public void PostOrderTraversal()
    {
        PostOrderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void PostOrderTraversalRecursive(Node node)
    {
        if (node == null)
        {
            return;
        }

        PostOrderTraversalRecursive(node.Left);
        PostOrderTraversalRecursive(node.Right);
        Console.Write(node.Value + " ");
    }
    public void PrintTree()
    {
        PrintTreeRecursive(root, 0);
    }

    private void PrintTreeRecursive(Node node, int level)
    {
        if (node == null)
        {
            return;
        }

        PrintTreeRecursive(node.Right, level + 1);
        Console.WriteLine(new string(' ', level * 4) + node.Value);
        PrintTreeRecursive(node.Left, level + 1);
    }
}