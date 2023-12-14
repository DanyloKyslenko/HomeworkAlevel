using MyBinaryTree;
using MyDoublyLinkedList;
class Program
{
    static void Main(string[] args)
    {
        var tree = new BinarySearchTree();
        tree.Add(10);
        tree.Add(5);
        tree.Add(15);
        tree.Add(3);
        tree.Add(7);
        tree.Add(12);
        tree.Add(17);

        foreach (var value in tree)
        {
            Console.WriteLine($"Tree item {value}");
        }
        /*
        tree.Traversal(value => Console.WriteLine(value), TraversalOrder.Pre);
        tree.Traversal(value => Console.WriteLine(value), TraversalOrder.In);
        tree.Traversal(value => Console.WriteLine(value), TraversalOrder.Post);
        */
        var list = new CustomDoublyLinkedList<int>();

        list.Add(1);

        list.Add(2);

        list.Add(3);


        foreach (var element in list)

        {

            Console.WriteLine($"List item {element}");

        }
        /*
        list.Remove(1);
        Console.WriteLine(list[1]);
        */
    }
}
