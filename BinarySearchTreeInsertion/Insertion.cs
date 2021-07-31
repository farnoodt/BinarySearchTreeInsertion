using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeInsertion
{
    class Insertion
    {
        public Node Insert(Node root, int data)
        {
            if (root == null)
                return new Node(data);

            if (data <= root.data)
                root.left = Insert(root.left, data);
            else
                root.right = Insert(root.right, data);

            return root;
        }
    }
}
