using BinarySearchTree;

BinaryTree binaryTree = new BinaryTree();
binaryTree.Add(56);
binaryTree.Add(30);
binaryTree.Add(70);
binaryTree.TraversePreorder(binaryTree.Root);

CreateBinaryFigure<int> createBinary = new CreateBinaryFigure<int>(56);
createBinary.Insert(30);
createBinary.Insert(70);
createBinary.Insert(22);
createBinary.Insert(40);
createBinary.Insert(60);
createBinary.Insert(95);
createBinary.Insert(11);
createBinary.Insert(65);
createBinary.Insert(3);
createBinary.Insert(16);
createBinary.Insert(63);
createBinary.Insert(67);
Console.WriteLine();
Console.WriteLine("Binary search tree (Inorder traversal/Assending is )");
createBinary.Display();
createBinary.Size();


SearchBinary<int> objsearchBinary = new SearchBinary<int>(56);
objsearchBinary.Insert(30);
objsearchBinary.Insert(70);
objsearchBinary.Insert(22);
objsearchBinary.Insert(40);
objsearchBinary.Insert(60);
objsearchBinary.Insert(95);
objsearchBinary.Insert(11);
objsearchBinary.Insert(65);
objsearchBinary.Insert(3);
objsearchBinary.Insert(16);
objsearchBinary.Insert(63);
objsearchBinary.Insert(67);
Console.WriteLine(" Binary search tree (Inorder traversal/Ascending is ) ");
objsearchBinary.Display();
objsearchBinary.SearchTree(67, objsearchBinary);
objsearchBinary.Size();
