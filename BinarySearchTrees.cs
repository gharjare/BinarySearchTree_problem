using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    public class BinarySearchTrees<T> where T : IComparable
    {

        public T NodeData { get; set; }
        
        
        
        public Node<T> root;
        public int leftCount, rightCount;
        

        public BinarySearchTrees(Node<T> root)
        {
            this.root = root;
            
        }

        public Node<T> Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (root == null)
            {
                root = newNode;
                return root;

            }
            if (root.data.Equals(data))
            {
                Console.WriteLine($"{data} is already present in Binary search tree");
                return root;
            }
            else if (data.CompareTo(root.data) < 0)
            {
                if (root.left != null)
                {
                    root = root.left;
                    Insert(data);
                }
                else
                {
                    root.left = newNode;
                }
            }
            else if (data.CompareTo(root.data) > 0)
            {
                if (root.right != null)
                {
                    root = root.right;
                    Insert(data);
                }
                else
                {
                    root.right = newNode;
                }
            }
            return root;
        }
        public void InOrderTraversal(Node<T> root)
        {
            if (root.left != null)
            {
                InOrderTraversal(root.left);
                leftCount++;
            }
            Console.Write(root.data + " ");
            if (root.right != null)
            {
                InOrderTraversal(root.right);
                rightCount++;
            }
        }
        public void TreeSize()
        {
            Console.WriteLine($"\n\nThe size of binary search tree is : {1 + leftCount + rightCount}");
        }
        int idx = -1;
        public Node<T> createTree(int nodes)
        {
            idx++;
            if (nodes == -1)
            {
                return null;
            }
            Node<T> newNode = new Node<T>(NodeData);
            newNode.left = createTree(nodes);
            newNode.right = createTree(nodes);
            return newNode;
        }
        public void inOrder(Node<T> root)
        {
            if (root == null)
            {
                Console.WriteLine(-1 + " ");
                return;
            }
            Console.WriteLine(root.data + " ");
            inOrder(root.left);
            inOrder(root.right);
        }


    }
}
        
