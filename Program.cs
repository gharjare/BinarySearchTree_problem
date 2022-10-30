using System.Xml.Linq;

namespace BinarySearchTree
{
    class program
    {
        public static void Main(string[] args)
        {
            Node<int> root = new Node<int>(56);
            BinarySearchTrees<int> bst = new BinarySearchTrees<int>(root);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(63);
            bst.Insert(67);
            Console.WriteLine("Inorder Traversal of given binary tree is : ");
            bst.InOrderTraversal(root);
            bst.TreeSize();
            Console.ReadLine();




        }
}