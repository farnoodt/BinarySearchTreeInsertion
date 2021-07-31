using System;

namespace BinarySearchTreeInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Insertion In = new Insertion();
            Node tree = new Node(10);
            In.Insert(tree, -5);
            In.Insert(tree, -8);
            In.Insert(tree, 7);
            In.Insert(tree, 16);
            In.Insert(tree, 18);
            Console.WriteLine("Hello World!");
        }
    }
}
