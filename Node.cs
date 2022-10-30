using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node<T>
    {



        public T data;
        public Node<T> left;
        public Node<T> right;
        public Node(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }      
    
}

