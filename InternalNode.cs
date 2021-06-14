using System;
using System.Collections.Generic;

namespace CodeTest
{
    // Print all Internal Nodes
    class InternalNode
    {
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int data)
            {
                left = null;
                right = null;
                this.data = data;
            }
        }

        static void printInternalNodes(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                Node current = q.Peek();
                q.Dequeue();

                bool inInternal = false;

                if (current.left != null)
                {
                    inInternal = true;
                    q.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    inInternal = true;
                    q.Enqueue(current.right);
                }

                // In case the node has either a left 
                // or right child or both print the data 
                if (inInternal == true)
                    Console.Write(current.data + " ");
            }
        }

        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.right.left = new Node(5);
            root.right.right = new Node(6);
            root.right.right.right = new Node(10);
            root.right.right.left = new Node(7);
            root.right.left.left = new Node(8);
            root.right.left.right = new Node(9);

            // A call to the function 
            printInternalNodes(root);
        }
    }
}
