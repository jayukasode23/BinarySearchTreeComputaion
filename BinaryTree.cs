using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public bool Add(int value)
        {
            Node befor = null, after = this.Root;

            while (after != null)
            {
                befor = after;
                if (value < after.Data)
                    after = after.LeftNode;

                else if (value > after.Data)
                    after = after.RightNode;
                else
                {
                    return false;
                }
            }
            Node newnode = new Node();
            newnode.Data = value;
            if (this.Root == null)
            {
                this.Root = newnode;
            }
            else
            {
                if (value < befor.Data)
                    befor.LeftNode = newnode;
                else
                    befor.RightNode = newnode;

            }
            return true;

        }
        public void TraversePreorder(Node Parent)
        {
            if (Parent != null)
            {
                Console.WriteLine(Parent.Data + " ");
                TraversePreorder(Parent.LeftNode);
                TraversePreorder(Parent.RightNode);

            }
        }
    }
}
