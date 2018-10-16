using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int Value;
        Node LeftChild;

        Node Left;
            
        public Node RightChild;
        public  Node(int value)
        {
            this.Value = value;
            LeftChild = null;
            RightChild = null;
           
        }

        public Node(List<int> value)
        {
            this.value = value;
        }

        Node root;
        private List<int> value;

        public void Add(int Value)
        {

            Node node = new Node(Value);

            if (root == null)

            {
                root = node;
            }
            Node current = root;
            Node parent;

            while (true)
            {
                parent = current;
                if (Convert.ToInt32(node.Value) < Convert.ToInt32(parent.Value))
                {

                    current = current.LeftChild;
                    if (current == null)
                    {
                        parent.LeftChild = node;
                        node.Value = Convert.ToInt32(LeftChild);
                        return;
                    }

                }
                else
                {
                    current = current.RightChild;
                    if (current == null)
                    {
                        parent.RightChild = node;
                        node.Value = Convert.ToInt32(RightChild);
                        return;
                    }
                }


            }

    
    }   }
}
