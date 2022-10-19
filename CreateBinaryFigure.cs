using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
  
    
        //Creating a generic class and implemating IComparable interface,because we need to compare every time we insert a new node.
        public class CreateBinaryFigure<T> where T : IComparable<T>
        {
            public T NodeData { get; set; }
            //For left sub Tree
            public CreateBinaryFigure<T> LeftTree { get; set; }
            //For Right sub Tree
            public CreateBinaryFigure<T> RightTree { get; set; }

            public CreateBinaryFigure(T nodeData)
            {
                NodeData = nodeData;
                LeftTree = null;
                RightTree = null;
            }
            //declaring static variables for counting total node in left and right subtree.
            public static int leftCount = 0, rightCount = 0;

            //Insertion logic
            public void Insert(T item)
            {
                T currentNodeValue = NodeData;

                //If currentNodeValue is greater than item
                if (currentNodeValue.CompareTo(item) > 0)
                {
                    // If left subtree is null.
                    if (LeftTree == null)
                    {
                        //put item in the left subtree
                        LeftTree = new CreateBinaryFigure<T>(item);

                    }
                    //if left subtree is not null
                    else
                    {
                        //recursive Insert method call on left subtree.
                        LeftTree.Insert(item);
                    }

                }
                //else current Node value is less than item.
                else
                {
                    //if right subtree is null
                    if (RightTree == null)
                    {
                        //then put item in right subtree root or parent node.
                        RightTree = new CreateBinaryFigure<T>(item);
                    }
                    //If right subtree is not null
                    else
                    {
                        //recursive Insert method call on right subtree.
                        RightTree.Insert(item);
                    }
                }
            }
            //for displaying binary search tree
            public void Display()
            {
                //If Left Subtree is not null
                if (LeftTree != null)
                {
                    // Left subtree is not null here therefore increment the node count of left subtree i.e. leftCount++
                    leftCount++;
                    //then call display method recursively on left subtree.
                    LeftTree.Display();
                }
                //For printing the value present at the node.
                Console.WriteLine(NodeData.ToString() + " ");

                //If Right Subtree is not null
                if (RightTree != null)
                {
                    // Right subtree is not null here therefore increment the node count of Right subtree i.e. rightCount++
                    rightCount++;

                    //then call display method recursively on Right subtree.
                    RightTree.Display();

                }
            }
            //for calculating the size of BST
            public void Size()
            {
                //prints left subtree count + right subtree count + 1(for root node)
                Console.WriteLine("Size of BST is: " + (1 + leftCount + rightCount));
            }

        }
}
